import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Input as OSWidgets$Input, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.s_Storage.StorageDeleted.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.s_Storage.StorageDeleted.mvc$controller.js";
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yeK4MUp+3kmci4TO7wVejA#ValueExpression.1201708665.1", "Filename or Supplier Number"),
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
}, $text(getTranslation("rgmQOe+3hEmBtoiqdCi29w#Value", "Find")))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "5",
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
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "I"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "DeletedStorage.Concept",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2h6p3AWshEGZoQUjoSIptg#Value", "Concept"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "DeletedStorage.Filename",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+LiuksF9VEuBGXN_xOQH0A#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "DeletedStorage.Vendor",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JEV9gOrOK0OKna_iTHlqXQ#Value", "Vendor"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "DeletedStorage.Doc_Type",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YGIxpBuEvEKWl6JLrbM8jA#Value", "Doc Type"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "DeletedStorage.Object_type",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FEIqvkrzokKj3+eBTdA4UQ#Value", "Object type")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.idAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.longIntegerToText(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.idAttr),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.arc_Doc_IDAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.conceptAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.conceptAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.arc_Doc_IDAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.filenameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.filenameAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.vendorAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.vendorAttr,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.doc_TypeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.doc_TypeAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.object_typeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.storageListAggr.listOut.getCurrent(callContext.iterationContext).deletedStorageAttr.object_typeAttr,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.storageListAggr.dataFetchStatusAttr)
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
MaxRecords: model.variables.maxRecordsVar,
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
uuid: "27",
alias: "3"
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
uuid: "28"
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
uuid: "29"
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
_dependencies: [asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.storageListAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.storageListAggr.countOut), asPrimitiveValue(model.variables.storageListAggr.listOut), asPrimitiveValue(model.variables.keywordVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "StorageDeleted",
functionKey: "0f4be99c-7ec7-48bb-9260-25bb919bed9e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "s_Storage.StorageDeleted",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.s_Storage.StorageDeleted.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
