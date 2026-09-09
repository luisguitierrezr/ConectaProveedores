import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Label as OSWidgets$Label, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { ST_6ac87b97c676cd17082ba2063283d4baStructure } from "./ConectaProveedores.model.js";
import { Navigation as OS$Navigation, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkComment.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkComment.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
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
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Vx64hj678k2mvSKvTrUE5g#Value", "Comment invoices"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, new ST_6ac87b97c676cd17082ba2063283d4baStructure(), controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ouScCE90u0mn3vSNlA7NDQ#Value", "You\'re commenting the following invoices:"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.vertical,
Height: "500px"
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
uuid: "9",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.l_InvoiceApprovalLevelListIn,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceId.Name",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("eTMKRScZVEu5Cz9qUMoVnw#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "InvoiceId.TotalAmount",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mRomH0C6fU6xpFz30IHyrQ#Value", "Total Amount")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus), asPrimitiveValue(model.variables.l_InvoiceApprovalLevelListIn.getCurrent(callContext.iterationContext).invoiceIdAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_InvoiceApprovalLevelListIn.getCurrent(callContext.iterationContext).invoiceIdAttr.nameAttr,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus), asPrimitiveValue(model.variables.l_InvoiceApprovalLevelListIn.getCurrent(callContext.iterationContext).invoiceIdAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("hcxbC+rHF06EzSsVdnUjpg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.l_InvoiceApprovalLevelListIn.getCurrent(callContext.iterationContext).invoiceIdAttr.totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.l_InvoiceApprovalLevelListIn.getCurrent(callContext.iterationContext).invoiceIdAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus)
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables._l_InvoiceApprovalLevelListInDataFetchStatus), asPrimitiveValue(model.variables.l_InvoiceApprovalLevelListIn)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("SHmPTRKkb0uYYKku6sjpkA.Style"), function () {
return ("os-boxlabel margin-top-m " + ((model.widgets.get(idService.getId("TextArea_l_Comment")).validAttr) ? (" ") : ("os-error")));
}, function () {
return model.widgets.get(idService.getId("TextArea_l_Comment")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_l_Comment",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Tov0wfZiLECDmgLpJIIXSg#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 250,
style: "form-control",
textLines: 2,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_CommentVar, function (value) {
model.variables.l_CommentVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_Comment"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsExecutingVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, new ST_6ac87b97c676cd17082ba2063283d4baStructure(), controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qR9ug8EsTkWWz_2XCMAGSA#Value", "Close"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsLoading: model.variables.l_IsExecutingVar
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
uuid: "24",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsExecutingVar)),
extendedProperties: {
style: "border-width: 0px; min-width: 100px; max-width: fit-content; width: auto;"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-download btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("QIoKG+nylkCk2wQyum7eiw#Value", "Confirm")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsExecutingVar)]
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_PopupInvoiceBulkComment",
functionKey: "78342725-7342-486b-b630-70cc4ff5f84e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_InvoicePopups.Wb_PopupInvoiceBulkComment",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
