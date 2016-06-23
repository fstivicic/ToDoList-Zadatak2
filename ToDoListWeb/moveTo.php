<!DOCTYPE html>
<?php
   require 'database.php';
	$s = str_split($_GET['flag']);
   $sql = "UPDATE Task SET Flag = '".$s[0]."' WHERE ID == ".$_GET['id'];
   $ret = $db->query($sql);
   
	header('Location: ' . $_SERVER["HTTP_REFERER"] );
	exit;
?>