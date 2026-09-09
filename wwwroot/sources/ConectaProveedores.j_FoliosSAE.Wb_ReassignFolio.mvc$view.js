import { withBaseWebBlock, textWidget as $text, getTranslation, asPrimitiveValue, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$view.js";
import { createElement } from "react";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Form as OSWidgets$Form, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import Telcel_Theme_Utils_Wb_SupplierName_mvc_view from "./Telcel_Theme.Utils.Wb_SupplierName.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_LabelText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4ym6GGeKe0GkLjO_w29nDw#Value.-1691717446.1", "Original User"),
i_UserId: model.variables.l_SourceUserIdVar,
i_IsMandatory: true,
i_IsValid: true,
i_IsFilter: true,
i_IsDisable: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (userIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_SearchUserOriginal$Action(userIdIn, controller.callContext(eventHandlerContext));
});
;
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
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "FoliosList"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-base custom-container",
visible: true,
_idProps: {
service: idService,
name: "Folios"
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
}, $text(getTranslation("kxM1Na5g+UC75OZ_Yp+glg#Value", "Folios SAEC"))), $if(model.variables.getFolioApprovalLevelsByAssignedToAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6RNfCU6HREq+KQOy7awfJQ#Value", "No folios pending at this moment")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-scroll-container",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkbox_IsSelectAllOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsSelectAllVar, function (value) {
model.variables.l_IsSelectAllVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelectAll"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("94h1dKh7Jkq4HX_J2UtNMg#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Supplier.Name",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gRUNo1DSOUadhCNxMkWlBA#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.FolioNumber",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("e7LeyTKxL0iF9xvav9fsqQ#Value", "Folio SAEC"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "ApprovalStatus.LabelES",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ERD125UNcUOzOv0NyhXpvg#Value", "Action"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioApprovalLevel.LevelNumber",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rocAjyFNp0+cvHnnpXJQiw#Value", "Approval level")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-verticall",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkbox_IsSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_SupplierName_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierName: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr,
_i_SupplierNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
i_NChar: 20,
i_SupplierNumber: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_i_SupplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelESAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
i_Text: model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelESAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.levelNumberAttr)]
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
value: (model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.levelNumberAttr).toString(),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar)]
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
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "UserSubstitute"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_LabelText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fq4EPg+Cc0mOrG2DaGIJJQ#Value.-1165629425.1", "User Substitute"),
i_IsFilter: true,
i_IsDisable: false,
i_IsValid: true,
i_IsMandatory: true,
i_UserId: model.variables.l_SubstituteUserIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (userIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SearchUserSubstitute$Action(userIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "31",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m custom-textarea",
visible: true,
_idProps: {
service: idService,
name: "Reason"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
style: "mandatory",
targetWidget: "TextArea_l_Motive",
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4ajrdnEsxkaOPSNpXqmjow#Value", "Motive"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 500,
style: "\"form-control\"",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_MotiveVar, function (value) {
model.variables.l_MotiveVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_Motive"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m text-align-right",
visible: true,
_idProps: {
service: idService,
name: "ReplaceButton"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("Jwc5XrKarUWJGpDVt+k3qw.Enabled"), function () {
return (((((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())) && ((model.variables.l_SubstituteUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier()))) && ((OS$BuiltinFunctions.trim(model.variables.l_MotiveVar)) !== (""))) && (model.variables.l_IsSelectAllVar || model.variables.l_IsSelectVar));
}, function () {
return model.variables.l_SourceUserIdVar;
}, function () {
return model.variables.l_SubstituteUserIdVar;
}, function () {
return model.variables.l_MotiveVar;
}, function () {
return model.variables.l_IsSelectAllVar;
}, function () {
return model.variables.l_IsSelectVar;
}),
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.replaceOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gniBM51FQEicU6SX4ULT8g#Value", "Replace")))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowConfirmPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JxIUXubqP02uTAmcuCT76w#Value.1569513275.1", "Are you sure you want to reassign this activities to the new assigned user?"),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IQhu5FgnEUGZn40yJ5nyPA#Value.1917650272.1", "Reassignment")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_ConfirmPopupConfirm$Action(controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_ConfirmPopupClose$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "39",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ReassignFolio",
functionKey: "38fc8497-7691-4921-b8c1-0f9b7ab838cf",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_ReassignFolio",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, Telcel_Theme_Utils_Wb_SupplierName_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
