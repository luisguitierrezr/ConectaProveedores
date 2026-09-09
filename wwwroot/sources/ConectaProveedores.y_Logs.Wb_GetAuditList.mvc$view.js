import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup, Label as OSWidgets$Label, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Logs.Wb_GetAuditList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Logs.Wb_GetAuditList.mvc$controller.js";

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
style: "card",
visible: true,
_idProps: {
service: idService,
name: "body"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "list"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getDataDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getDataDataAct.auditListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("muCHWC9xRU2v4bb9HCJOEw#Value", "There are no entries at this time."))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "4",
alias: "1"
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
source: model.variables.getDataDataAct.auditListOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "RequestDistributionConfigsTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nt9rFBxipU2DDZ9DH2CV9Q#Value", "Identifier"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QTgHtH1+h06R6LYohhDJDw#Value", "Message"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fBQll4YRjk6fJ5ttX_nRXQ#Value", "User"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tpfM8DQjY0WchognxkdnIA#Value", "Date/Time"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).identifierAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.longIntegerToText(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).identifierAttr),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).messageAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).messageAttr,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceUserAttr,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("h0YWrlyp+kaaDTCbNMf3wQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr, "dd.MM.yyyy HH:mm:ss");
}, function () {
return model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).occurrenceDateTimeAttr;
}),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.linkOnClick$Action(model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).originalJSONAttr, model.variables.getDataDataAct.auditListOut.getCurrent(callContext.iterationContext).changeJSONAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-bold font-size-h5 text-info",
value: "...",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDataDataAct.auditListOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.maxRecordsIn,
_maxRecordsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._maxRecordsInDataFetchStatus),
TotalCount: model.variables.getDataDataAct.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDataDataAct.dataFetchStatusAttr),
StartIndex: model.variables.startIndexVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "22",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: Widget.PlaceholderContent.Empty,
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "23"
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
uuid: "24"
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
name: "loader"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showPopupVar,
style: "popup-dialog-1000 card",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "27"
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
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5g+_egcE_kG6trg2tZYNfA#Value", "Before"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 99999,
style: "form-control",
textLines: 10,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.jSON_AfterVar, function (value) {
model.variables.jSON_AfterVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_JSON_After"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5i663e+45EmzGNA8r7qZ9w#Value", "After"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 99999,
style: "form-control",
textLines: 10,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.jSON_BeforeVar, function (value) {
model.variables.jSON_BeforeVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_JSON_Before"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("51K1zTwukES_WYW7YGGKSg#Value", "Close"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_GetAuditList",
functionKey: "67fbb25d-8455-4c51-880e-3f82f919f5f2",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Logs.Wb_GetAuditList",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Logs.Wb_GetAuditList.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
