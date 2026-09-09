import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Link as OSWidgets$Link, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.CheckDirectReports.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.CheckDirectReports.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ChatBotIsEnable: true,
Initiative: "FCP"
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("PtluHuCxiECfyS6Xg+O7Pw#Value", "Direct Report Pending Approval"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "list_container"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFoliosDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getFoliosDataAct.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("o3EZ7UXiRkqKp3QjiXYhhA#Value", "There are no pending folios at this time."))],
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
name: "TableSettings"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setColumnVisiblityOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "OpenPopupLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-semi-bold italic",
text: [$text(getTranslation("kWYVQm0OYkSqq3_ApOtH_g#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
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
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
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
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFoliosDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "DirectReportsFormsTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Folio.FolioNumber",
style: "donotshow",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("BleHHC0YlEy31Qzlfcoe8Q#Value", "Form Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("piqnVOeIUUOTQbvgX65Hbw#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("un9Vvqqej0axgXHzmsrQoQ#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Region.Code",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yJhPYxoA4UyJYggIzuSLrw#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Folio.TotalAmount",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2bNOgARTtkqAZOPTeKUCBA#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("D+kk0vFNg06P8wZ2sm1IUg#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Folio.CreatedOn",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("atIyQ4q2SEmHepjnFMVWYg#Value", "Upload Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Folio.FolioStatusId",
style: "donotshow",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("keSJnQoye0C++D+IfwmzSg#Value", "Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsDirectReport: OS$DataConversion.ServerDataConverter.to(true, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr),
i_NChar: 20
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
uuid: "21",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr),
i_NChar: 20
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
uuid: "23",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_SupplierName: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr),
i_SupplierNumber: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
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
uuid: "25",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("DL_9PUp0z0aFB7Su48ZTHg.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("mnWMXhnHYkid4Ep9szHE2A.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr),
i_Class: model.variables.getFoliosDataAct.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosDataAct.dataFetchStatusAttr)
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
name: "RequisitionStatus",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ConfigColumnJSON: model.variables.l_ColumnJSONVarVar,
TableName: idService.getId("DirectReportsFormsTable"),
PopupBtnId: idService.getId("OpenPopupLink"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
passColumnObj$Action: function (columnJSONIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.columnTogglerPassColumn$Action(columnJSONIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "37",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut)]
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
name: "loader"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.getFoliosDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosDataAct.listOut), asPrimitiveValue(model.variables.getFoliosDataAct.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "CheckDirectReports",
functionKey: "0f79cab7-c882-4d34-afed-677047296f12",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.CheckDirectReports",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view];
};


return ELEM;
};

export default componentFactory()
