const uri = '/lunch';
const strrecipes='{  "recipes": [{     "title": "Ham and Cheese Toastie",     "ingredients": [     "Ham",     "Cheese",     "Bread",    "Butter"   ]    }, {    "title": "Fry-up",    "ingredients": [    "Bacon",    "Eggs",    "Baked Beans",    "Mushrooms",    "Sausage",    "Bread"    ]    }, {    "title": "Salad",    "ingredients": [    "Lettuce",    "Tomato",    "Cucumber",    "Beetroot",    "Salad Dressing"    ]    }, {    "title": "Hotdog",    "ingredients": [    "Hotdog Bun",    "Sausage",    "Ketchup",    "Mustard"    ]    }]    }';
const stringredients='{    "ingredients": [{    "title": "Ham",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Cheese",    "best-before": "2021-03-08",    "use-by": "2021-03-13"    }, {    "title": "Bread",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Butter",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Bacon",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Eggs",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Mushrooms",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Sausage",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Hotdog Bun",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Ketchup",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Mustard",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Lettuce",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Tomato",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Cucumber",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }, {    "title": "Beetroot",    "best-before": "2021-03-25",    "use-by": "2021-03-27"    }]    }';
//const strtest='[{"title":"abcd","val": "1234"}]';

function getlunchrecipes(){
   // var obj = JSON.parse(strtest);
   var recobj=JSON.parse(strrecipes);
   var ingrobj=JSON.parse(stringredients);
   console.log(JSON.stringify({ingredients:ingrobj.ingredients, recipes:recobj.recipes}));
    fetch(uri, {
        method: 'POST',
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ingredients:ingrobj.ingredients, recipes:recobj.recipes})     //.replace(/\/Date/g, "\\\/Date").replace(/\)\//g, "\)\\\/")
    }).then(function (response) {
        return response.json();
    })
    .then(function (data) {
        _displayItems(data);
    })
    .catch(function (err) {
        console.log('error: ' + err);
    });
}
function _displayItems(data) {
    console.log(data);
    var mainContainer = document.getElementById("myData");
    for (var i = 0; i < data.length; i++) {
        var div = document.createElement("div");
        div.innerHTML = 'Name: ' + data[i].title;
        mainContainer.appendChild(div);
    }
}