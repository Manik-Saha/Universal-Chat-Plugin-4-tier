app.controller("allUser",function($scope,ajax){
    ajax.get(API_ROOT+"api/User/All",function(response){
        $scope.allUser = response.data;
    },
    function(error){

    });
});