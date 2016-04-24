var app = require('app')
var http = require('http');

var window = require('browser-window')



app.on('ready',function () {
    var mainWindow = new window({
        width: 800,
        height: 600
    })
    ___dirname = "IPCLEARNINGTHING"
  mainWindow.loadUrl('file://' + __dirname + '/index.html');
    console.log("loaded URL");
    
  });





