import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Link as OSWidgets$Link, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.OrderRequestFilesApproval.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.OrderRequestFilesApproval.mvc$controller.js";
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
Initiative: "FCP",
ChatBotIsEnable: true
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
text: [$text(getTranslation("qWm5YuXJAE+kdb5rRfHYJw#Value", "Order documents"))],
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
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderRequestFileApprovalLevelsAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7OHn7A8rGUi6bXOeyK50Ag#Value", "There are no documents to approve.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-xs text-align-right",
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
text: [$text(getTranslation("9M9+GYijoU2u3HM2QS3mnA#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "7",
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
source: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "OrderRequestFileApprovalLevels"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderNumber",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NVaRrO7nAE2D_9tE1jV7xg#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Description",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("etvc9usWF0iE4iMiUVg4mQ#Value", "Client"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "TotalAmount",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jn7PYndQ7ky9PtdhQFwREg#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Code",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MdFAqnJb10us6swe6xcCBA#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderDate",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hXw6wC0W+0mmygcttWzScw#Value", "Order Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Label",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("AnHk1IzHEkibuTPKa7o0tw#Value", "Order Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right text-align: center;"
},
sortAttribute: "Count",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("lPUTkeHVtkWxMg0BPrp7XA#Value", "Files to approve")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderNumberAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rnR8G+wOUEW01bYWKoVIHA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).codeAttr,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("e0lymn3hMUuI+GeVt71t7g.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderDateAttr;
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).classAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).labelAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Class: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
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
uuid: "30",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).countAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.longIntegerToText(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).countAttr),
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ConfigColumnJSON: model.variables.l_ColumnJSONVarVar,
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("OrderRequestFileApprovalLevels")
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
uuid: "33",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.getOrderRequestFileApprovalLevelsAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
StartIndex: model.variables.l_StartIndexVar,
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "34",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "35",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.countOut), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "OrderRequestFilesApproval",
functionKey: "21eae004-4fd6-4cfc-a5b8-2b4abc9d501b",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.OrderRequestFilesApproval",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.e_OrdersRequestFiles.OrderRequestFilesApproval.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view];
};


return ELEM;
};

export default componentFactory()
