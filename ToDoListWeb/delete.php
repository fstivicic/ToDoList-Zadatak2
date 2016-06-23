<?php
   require 'database.php';

   $sql = "DELETE FROM Task WHERE ID == ".$_GET['id'];
   $ret = $db->query($sql);
   
	header('Location: ' . $_SERVER["HTTP_REFERER"] );
	exit;
?>