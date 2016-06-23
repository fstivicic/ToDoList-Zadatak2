<!DOCTYPE html>
<?php
   require 'database.php';

   $sql =<<<EOF
      SELECT * from Task WHERE Flag LIKE 'D';
EOF;

   $ret = $db->query($sql);
?>
<html>
    <head>
		<?php require 'header.php'?>
    </head>
	<body>
		<div id="page-content" class="container">
			<div id="directory-list-header">
                <div class="row">
                    <div class="col-md-4 col-sm-3 col-xs-10">Task</div>
                    <div class="col-md-6 col-sm-5 col-xs-2">Details</div>
                    <div class="col-md-2 col-sm-3 hidden-xs text-right">Change status</div>
                </div>
            </div>
			<?php while($row = $ret->fetchArray(SQLITE3_ASSOC) ){?>
				<div class="row">
                                <span class="name col-md-3 col-sm-6 col-xs-9">
                                    <?php echo $row['Name']; ?>
                                </span>

                                <span class="name col-md-6 col-sm-2 col-xs-3">
                                    <?php echo $row['Details']; ?>
                                </span>

                                <span class="name col-md-3 col-sm-4 hidden-xs text-right">
                                    <?php echo '<a href="moveTo.php?id='.urlencode($row['ID']).'&flag='.urlencode("P").'">Pending</a>
												<span>|</span>
												<a href="moveTo.php?id='.urlencode($row['ID']).'&flag='.urlencode("T").'">To Do</a>
												<span>|</span>
												<a href="delete.php?id='.urlencode($row['ID']).'">Delete</a>'; ?>
                                </span>
								
                            </div>
				<hr>
			<?php } ?>	
		</div>
	</body>
</html>
<?php $db->close();?>