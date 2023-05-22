<?php
try {
	$db =  new mysqli("localhost", "root", "", "teb_register");
	echo "ok";
}catch(mysqli_sql_exception $e){
	echo "Błąd: ".$e->getMessage();
}

