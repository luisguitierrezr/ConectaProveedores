import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, Image as OSWidgets$Image, Input as OSWidgets$Input, Link as OSWidgets$Link, List as OSWidgets$List, Expression as OSWidgets$Expression, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataTypes as OS$DataTypes, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "margin-top-14px",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KTL6qswfVEyohGUMznU4qg#Value", "Username"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zd7ezN_IdkyPGGEEpa06_A#ValueExpression.65921.1", "All"),
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.userNameAttr;
},
list: model.variables.getUsersAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.userNameAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_UserNameVar, function (value) {
model.variables.l_UserNameVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("MUrNn8iQWUy72hWZNoe+Ng#Value", "Date"))), createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ShowTodayButton: true,
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnSelected$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerID2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "8",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "padding: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClick$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
style: "margin-top: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V9AcM6zkrUe_qs4TJXqZxA#Value.1002767249.1", "Select a date")
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gxXNQMB6f0aLdqqlr+r_Bg#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.l_DateTimeVarVar, function (value) {
model.variables.l_DateTimeVarVar = value;
}),
_idProps: {
service: idService,
name: "Input_DateTimeVar"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_DateTimeVarVar)]
})];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_DateTimeVarVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.searchOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
classes: "OSFillParent"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_buscar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: model.getCachedValue(idService.getId("Wmqg9PJJm0+iBw95oowz2Q.Visible"), function () {
return (!(model.variables.l_DateTimeVarVar.equals(OS$BuiltinFunctions.nullDate())) || ((model.variables.l_UserNameVar) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, function () {
return model.variables.l_DateTimeVarVar;
}, function () {
return model.variables.l_UserNameVar;
}),
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearFilters$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: model.getCachedValue(idService.getId("2CyMbmv2pES_NxR8BROA_Q.Visible"), function () {
return (!(model.variables.l_DateTimeVarVar.equals(OS$BuiltinFunctions.nullDate())) || ((model.variables.l_UserNameVar) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, function () {
return model.variables.l_DateTimeVarVar;
}, function () {
return model.variables.l_UserNameVar;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l margin-left-s",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-m margin-bottom-s",
visible: (!(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.isEmpty)),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadExcelFile$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Frame12010.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}))), $if(model.variables.getInvoiceLogsByInvoiceIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoiceLogsByInvoiceIdAggr.listOut,
style: "list list-group margin-top-s",
tag: "div",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.messageAttr), asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdOnAttr), asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdByAttr), asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.isErrorAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl-item",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tl-left",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("jxzR0fPQHESACBXhQcnBuw.Style"), function () {
return ((model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.isErrorAttr) ? ("tl-doterror") : ("tl-dot"));
}, function () {
return model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.isErrorAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
style: "tl-content",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: #9fa0a0; font-size: 12px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("DpBQZAx3bky3PRod3qmd+g.Value"), function () {
return (((((model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdByAttr === OS$BuiltinFunctions.nullTextIdentifier())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6O2t00PfCkOs1b9gNmdz9w#ValueExpression.-1803461041.1", "System")) : (model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)) + " - ") + OS$BuiltinFunctions.dateTimeToText(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdOnAttr));
}, function () {
return model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdByAttr;
}, function () {
return model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr;
}, function () {
return model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 14px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceLogAttr.messageAttr,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)
})))))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("l2MTW6ea20+81shq0yb8GA#ValueExpression.-664832838.1", "Logs shown:") + " ") + (model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.length).toString()),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.length >= 10) && OS$BuiltinFunctions.integerToLongInteger(model.variables.maxRecordsVar).lte(model.variables.countInvoiceLogsAggr.listOut.getCurrent(callContext.iterationContext).countAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.seeMoreOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-right",
text: [$text(getTranslation("vxsGZjx0g0G8E86HrbljTA#Value", "See More"))],
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("WchFvJ0qaUWhbRG5OZntQw#Value", "There\'s no more logs to see"))],
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceDetailsHistory",
functionKey: "c1f4cf4e-a82f-4668-80a4-e3347164a8c9",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoiceDetailsHistory",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view];
};


return ELEM;
};

export default componentFactory()
