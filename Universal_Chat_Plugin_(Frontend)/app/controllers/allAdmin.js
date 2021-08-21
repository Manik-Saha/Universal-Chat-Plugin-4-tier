app.controller("allAdmin",function($scope,ajax){
    ajax.get(API_ROOT+"api/Admin/All",function(response){
        $scope.allAdmin = response.data;
    },
    function(error){

    });
});