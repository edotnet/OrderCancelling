function renderTemplate(prefix, model) {
    var template = Handlebars.compile($(`#${prefix}Template`).html());
    var returnvalue = template(model);
    $(`#${prefix}Container`).html(returnvalue);
}