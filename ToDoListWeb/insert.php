<?php
   require 'database.php';
   
   if(!empty($_POST['name'])  && !empty($_POST['details'])):
		$sql = "INSERT INTO Task (Name,Details,Flag) VALUES ('".$_POST['name']."','".$_POST['details']."', '".$_POST['type']."')";
		$ret = $db->query($sql);
	header("Location:.");
	exit;
	endif;
?>
<!DOCTYPE html>
<html>
<head>
	<title>Insert new Task</title>
	<link rel="stylesheet" type="text/css" href="assets/css/style.css">
	<link href='http://fonts.googleapis.com/css?family=Comfortaa' rel='stylesheet' type='text/css'>
	<?php require 'header.php'?>
</head>
<body>

	<form align="middle" action="insert.php" method="POST">
		
		<div> <input type="text" placeholder="Task name" name="name"> </div>
		<hr></hr>
		<div> <textarea style="width: 300px; height: 100px;" type="text" placeholder="Task details" name="details"></textarea></div>
		<hr></hr>
		<div> <select name="type" onchange="document.getElementById('selected_text').value=this.options[this.selectedIndex].text">
			<option value="T">To Do</option>
			<option value="P">Pending</option>
			<option value="D">Done</option>
		</select>
		</div>
		<hr></hr>
		<div> <input type="submit" value="Create new task"/>
		</div>
		<hr></hr>

	</form>

</body>
</html>
