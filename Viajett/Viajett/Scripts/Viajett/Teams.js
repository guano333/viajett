var viajett;
(function (viajett) {
    var Teams = /** @class */ (function () {
        function Teams() {
        }
        Teams.prototype.loadTeams = function () {
            $.ajax({
                url: '/Home/Teams',
                type: 'GET',
                success: function (result) {
                    $("#teamcontent").html(result);
                }
            });
        };
        return Teams;
    }());
    viajett.Teams = Teams;
})(viajett || (viajett = {}));
//# sourceMappingURL=Teams.js.map