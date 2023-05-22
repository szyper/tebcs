<?php
	echo "<pre>";
		//print_r($_POST);
	echo "</pre>";

	require_once "./connect.php";
	$stmt = $db->prepare("INSERT INTO `users` (`firstName`, `lastName`, `email`, `birthday`, `password`) VALUES (?, ?, ?, ?, ?);");

	$stmt->bind_param("sssss", $_POST["firstName"], $_POST["lastName"], $_POST["email"], $_POST["birthday"], $_POST["pass"]);

	if ($stmt->execute()){
		header("location: ../pages/views/index.php?addUser=1");
	}else{
		header("location: ../pages/views/index.php?addUser=0");
	}

	//dodać pole miasto (city)

