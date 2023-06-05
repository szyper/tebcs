<?php
	session_start();
	echo "<pre>";
		//print_r($_POST);
	echo "</pre>";

	require_once "./connect.php";
	$stmt = $db->prepare("INSERT INTO `users` (`firstName`, `lastName`, `email`, `birthday`, `password`) VALUES (?, ?, ?, ?, ?);");

	$pass = password_hash($_POST["pass"], PASSWORD_ARGON2ID);

	$stmt->bind_param("sssss", $_POST["firstName"], $_POST["lastName"], $_POST["email"], $_POST["birthday"], $pass);

	if ($stmt->execute()){
		$_SESSION["success"] = "Prawidłowo dodano użytkownia $_POST[firstName] $_POST[lastName]";
		header("location: ../pages/views");
	}else{
		header("location: ../pages/views/index.php?addUser=0");
	}

	//dodać pole miasto (city)

