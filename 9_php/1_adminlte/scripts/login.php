<?php
	//print_r($_POST);

	require_once "./connect.php";
	$stmt = $db->prepare("SELECT * FROM users WHERE email=?");
	$stmt->bind_param("s", $_POST["login"]);
	$stmt->execute();
	$result = $stmt->get_result();
	if ($result->num_rows != 0){
		//echo "Email istnieje w db";
		$user = $result->fetch_assoc();
		if (password_verify($_POST["pass"], $user["password"])){
			echo "Zalogowany";
		}else{
			echo "Błędne hasło!";
		}
	}else{
		echo "Brak email-a!";
	}