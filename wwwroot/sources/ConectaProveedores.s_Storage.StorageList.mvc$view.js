import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Input as OSWidgets$Input, Button as OSWidgets$Button, Link as OSWidgets$Link, Icon as OSWidgets$Icon, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.s_Storage.StorageList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.s_Storage.StorageList.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ChatBotIsEnable: false
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
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width4"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YbLCQ7pqmE6zFUo2N0CckQ#ValueExpression.1201708665.1", "Filename or Supplier Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.keywordVar, function (value) {
model.variables.keywordVar = value;
}),
_idProps: {
service: idService,
name: "Input_TextVar"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.findOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Aj1OdT0NoEOJjFibkIEAZw#Value", "Find")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "StorageDeleted", {}),
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "eye",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
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
uuid: "8",
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
source: model.variables.storageListAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
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
}, "I"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Concept",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("X9cz25lEUE+DFrs7cw7htA#Value", "Concept"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Filename",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pGSXAKuBF0mZZO4jCRVwgw#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "Storage.Size",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Size (Mb)"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Vendor",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("CUpNl0212ESvVdntF6i97g#Value", "Vendor"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Doc_Type",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("D4DwOkJQK0uqZ0oeg86ZAA#Value", "Doc Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Storage.Object_type",
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("McXbgEx8VECiyvUrPLmxKQ#Value", "Object type"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Storage.IstoSendToExternal",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Mh8+AfI+UE6CffKN8I1ZRg#Value", "Is To Send To External"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Storage.IsExternal",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4u2BATTJjU+KgdbrqP2l1g#Value", "Is External"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Storage.IsToDelete",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("akg5tEs2h0uKBoZ3N4dzag#Value", "Is To Delete"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "Storage.SentWhen",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XzUSLj2PNUaMLk1ZveS+lQ#Value", "Sent When"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Storage.WithEntegrationError",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("y8cyMRhMiEKXjdQ1II1noA#Value", "With Integration Error"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Storage.IsToBig",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("5iIK1fKq6UKEP_o+9KK_sA#Value", "Is To Big"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr)]
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
i_StorageId: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
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
uuid: "26",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.longIntegerToText(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.arc_Doc_IDAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.conceptAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.attemptAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (((model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.attemptAttr).toString() + " - ") + model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.conceptAttr),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.arc_Doc_IDAttr,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}), createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
i_FileSize: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
i_Filename: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "35",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("0xbDRrt3s0e2TxuTkDB4Fw.Value"), function () {
return OS$BuiltinFunctions.decimalToText(OS$BuiltinFunctions.round(OS$BuiltinFunctions.longIntegerToDecimal(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr).div(OS$BuiltinFunctions.integerToDecimal((1024 * 1024))), 3));
}, function () {
return model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sizeAttr;
}),
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.vendorAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.vendorAttr,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.doc_TypeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.doc_TypeAttr,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.object_typeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.object_typeAttr,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.istoSendToExternalAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.istoSendToExternalAttr,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isExternalAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isExternalAttr,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isToDeleteAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isToDeleteAttr,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sentWhenAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("9w8EM0iaHkeI4BLqk6cYUg.Value"), function () {
return ((model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sentWhenAttr.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.dateTimeToText(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sentWhenAttr)));
}, function () {
return model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.sentWhenAttr;
}),
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.withEntegrationErrorAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.withEntegrationErrorAttr,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isToBigAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.isToBigAttr,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.withEntegrationErrorAttr)]
}, $if(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.withEntegrationErrorAttr, false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.resendOnClick$Action(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vgOhJChbCUGmZcL3+1FVLg#Value", "Resend")))];
}, function () {
return [];
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.storageListAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
StartIndex: model.variables.startIndexVar,
MaxRecords: model.variables.maxRecordsVar
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
uuid: "65",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "66"
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
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.countOut), asPrimitiveValue(model.variables.storageListAggr.listOut), asPrimitiveValue(model.variables.keywordVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "StorageList",
functionKey: "7ad2cf63-6e40-40b6-9f26-93ebe8d3debb",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "s_Storage.StorageList",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.s_Storage.StorageList.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
