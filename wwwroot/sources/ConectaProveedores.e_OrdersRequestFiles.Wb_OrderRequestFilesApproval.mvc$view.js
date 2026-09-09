import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Image as OSWidgets$Image, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_position as ConectaProveedores_staticEntities_position, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderFilePreviewDownload.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view from "./ExpandableTableRow.UIFlow.ExpandableTableRow.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrdReqFileRejectPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.mvc$controller.js";

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
}, $if(model.variables.getOrderRequestFileApprovalLevelsAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.isEmpty, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-xs text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "1"
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
text: [$text(getTranslation("l2PB2Ek9mkiqb8tIJivGtQ#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "3"
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
uuid: "4",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
extendedProperties: {
title: ((OS$BuiltinFunctions.longIntegerToText(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr) + "|") + model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)
},
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
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("lUcRBInGkEWfNotEJxl71g#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("e8PQlQO_0UqIYwE8Yc4YlQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderRequestFile.Description",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MRLDyXG8S0yLOFkFuxU5ow#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderRequestFile.Filename",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("bFurddU9HE+JdbHKg8QHsw#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "InvoiceStatus.Label",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4XWuZSkzYkK17EivLZ6jhA#Value", "Invoice"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "width: 1px; width: 1px;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.getCachedValue(idService.getId("D4kHJGeVuky5oC2csxsfFw.i_Text"), function () {
return ((((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZWt+LzF7kEyW5sMn4n4IMQ#Value.1070808798.1", "In Approval")) : (((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZWt+LzF7kEyW5sMn4n4IMQ#Value.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZWt+LzF7kEyW5sMn4n4IMQ#Value.-543852386.1", "Rejected")))));
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Class: model.getCachedValue(idService.getId("D4kHJGeVuky5oC2csxsfFw.i_Class"), function () {
return ((((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr === false) && (model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr === false))) ? ("inapproval") : (((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr) ? ("approved") : ("rejected"))));
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isApprovedAttr;
}, function () {
return model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.isRejectedAttr;
}),
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
uuid: "16",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.filenameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.filenameAttr,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "width: 1px;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.filenameAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr)]
}, $if(false, false, this, function () {
return [];
}, function () {
return [createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Size: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_SizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Filename: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
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
})];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "width: 1px;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileApprovalLevelAttr.approvalStatusIdAttr)]
}, $if((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "28",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approvRejectFile$Action(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileApprovalLevelAttr.idAttr, false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("iMnRlWmNtEyasmC4IRD8Rg#Value", "Reject"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "31",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approvRejectFile$Action(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileApprovalLevelAttr.idAttr, true, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("MPV4YCixzEKaC5zMVm0aJA#Value", "Approve"))];
})
},
_dependencies: []
}))];
}, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Class: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
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
uuid: "34",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr)]
}, $if((!(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.accounting) || (model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError)) || (model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationSuccess))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr),
i_Class: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
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
uuid: "37",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if((model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "38",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.recontabInvoice$Action(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr, controller.callContext(eventHandlerContext));
});
;
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
name: "Link_ReContab"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_recargar.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("puT7ko6zRUSbYgOOcxO08A#Value", "Resend to contabilization"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr)]
}, $if(!(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StyleCell: "text-align-center"
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
uuid: "42",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
iconClose: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "chevron-up",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
iconOpen: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "chevron-down",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
iconLabel: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr)
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
uuid: "45",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).orderRequestFileAttr.invoiceIdAttr)]
})];
}, function () {
return [];
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
PopupBtnId: idService.getId("OpenPopupLink"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
TableName: idService.getId("OrderRequestFileApprovalLevels"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarVar
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
uuid: "46",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderRequestFileApprovalLevelsAggr.listOut)]
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
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar
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
uuid: "47",
alias: "12"
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
uuid: "48",
alias: "13"
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
uuid: "49"
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
uuid: "50"
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
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.showHideOrdReqFileRejectPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderRequestFileApprovalLevelIdToReject: model.variables.l_OrderRequestFileApprovalLevelIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
reject$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.showHideOrdReqFileRejectPopup$Action(true, controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.showHideOrdReqFileRejectPopup$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "53",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderRequestFilesApproval",
functionKey: "96da8aba-bd7d-4090-9c0b-3129a48f6296",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.Wb_OrderRequestFilesApproval",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_OrderFilePreviewDownload_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ExpandableTableRow_UIFlow_ExpandableTableRow_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
