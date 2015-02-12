var sPerson = {"name":'{"message":"accurate","cod":"200","count":1,"list":[{"id":2618425,"name":"Copenhagen","coord":{"lon":12.56553,"lat":55.675941},"main":{"temp":3,"humidity":91,"pressure":976.9,"temp_min":3,"temp_max":3},"dt":1421233747,"wind":{"speed":8.17,"deg":224.506},"sys":{"country":"DK"},"rain":{"3h":1},"clouds":{"all":56},"weather":[{"id":500,"main":"Rain","description":"light rain","icon":"10d"}]}]}'};
var sName = sPerson.name
console.log(sName);


var util = require('util');
console.log("hi");
console.log("hello");
console.log("12345");


var passMe = '{"name":"Santiagoxxxxxx"}';

var http = require('http');
http.createServer(function (req, res) {
  res.writeHead(200, {'Content-Type': 'text/html'});


  console.log()
  res.end(sName+'\n');
}).listen(1339, '188.166.34.53');
console.log('Server running at http://127.0.0.1:1339/');
