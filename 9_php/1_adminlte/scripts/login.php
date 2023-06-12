<?php
//	print_r($_POST);
	session_start();
	require_once "./connect.php";
	$stmt = $db->prepare("SELECT * FROM users WHERE email=?");
	$stmt->bind_param("s", $_POST["login"]);
	$stmt->execute();
	$result = $stmt->get_result();
	//echo $result->num_rows;
	if ($result->num_rows != 0){
		//echo "Email istnieje w db";
		$user = $result->fetch_assoc();
		if (password_verify($_POST["pass"], $user["password"])){
			$_SESSION["logged"]["firstName"] = $user["firstName"];
			$_SESSION["logged"]["lastName"] = $user["lastName"];
			$_SESSION["logged"]["session_id"] = session_id();
			print_r($_SESSION["logged"]);

			header('location: ../pages/views/logged/logged.php');
			exit();
		}else{
			echo "Błędne hasło!";
		}
	}else{
		echo "Brak email-a!";
	}