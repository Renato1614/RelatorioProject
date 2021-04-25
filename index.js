
    $.ajax({
        url: "http://localhost:5000/api/relatorios",
        method: 'GET',
        dataType: 'text jsonp',
        headers: {
            'Content-Type': 'application/json; charset=utf-8',
        },
        statusCode:{
            200: function(data){
                console.log(data);
            }
        }
    })