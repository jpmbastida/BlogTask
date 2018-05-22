$(function () {
    function split(val) {
        return val.split(/,\s*/);
    }
    function extractLast(term) {
        return split(term).pop();
    }

    $("#textKeywords")
        .on("keydown", function (event) {
            if (event.keyCode === $.ui.keyCode.TAB &&
                $(this).autocomplete("instance").menu.active) {
                event.preventDefault();
            }
        })
        .autocomplete({
            minLength: 0,
            max: 6,
            highlightItem: true,
            multiple: true,
            multipleSeparator: " ",
            dataType: "json",
            source: function (request, response) {
                $.ajax({
                    type: "GET",
                    url: "/ArticlesManagement/GetTags",
                    data: { text: request.term },
                    success: function (data) {
                        response($.ui.autocomplete.filter(
                            data, extractLast(request.term)));
                    }
                });
            },
            focus: function () {
                return false;
            },
            select: function (event, ui) {
                $("input[type=hidden]").val(ui.item.id);
                var terms = split(this.value);
                terms.pop();
                terms.push(ui.item.value);
                terms.push("");
                this.value = terms.join(", ");
                return false;
            }
        });
});