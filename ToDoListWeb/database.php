<?php
   class MyDB extends SQLite3
   {
      function __construct()
      {
         $this->open('ToDoList.sqlite');
      }
   }
   $db = new MyDB();
   if(!$db){
      echo $db->lastErrorMsg();
   } ?>