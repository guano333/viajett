namespace viajett {
    export class Teams {
        loadTeams() {
            $.ajax({
                url: '/Home/Teams',
                type: 'GET',
                success: (result) => {
                    $("#teamcontent").html(result);
                }
            });
        }

    }
}
