app.controller("allOrganization",function($scope,ajax){
    ajax.get(API_ROOT+"api/Organization/All",function(response){
        $scope.allOrganization = response.data;
    },
    function(error){

    });
});