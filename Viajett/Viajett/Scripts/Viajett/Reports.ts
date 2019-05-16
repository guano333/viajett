namespace viajett {
    export class Reports {
        loadReports() {
            $.ajax({
                url: '/Home/Reports',
                type: 'GET',
                success: (result) => {
                    $("#reportcontent").html(result);
                }
            });
        }
    }
}
