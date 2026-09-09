import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.FoliosList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.FoliosList.mvc$controller.js";
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
title: Widget.PlaceholderContent.Empty,
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFoliosAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
sortAttribute: "Folio.IsDraft",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XWxLtYNW_kyhljmUz7hiLw#Value", "Is Draft"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.FolioNumber",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FNHAQMUqYE+DkdSq6t_O8g#Value", "Folio Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.OrderId",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("OBOFzft_wk+ZTgoa6yOPyg#Value", "Order"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Folio.SupplierId",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("amUICCt5MUidRaXm8n368g#Value", "Supplier")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.isDraftAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.isDraftAttr,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFoliosAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "IsTableLoadingOrEmpty"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFoliosAggr.isDataFetchedAttr && model.variables.getFoliosAggr.listOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SdZFr1vJy0mPQF+iG1GLdg#Value", "No items to show...")))];
}, function () {
return [$if((!(model.variables.getFoliosAggr.isDataFetchedAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
})), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.maxRecordsVar,
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getFoliosAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosAggr.dataFetchStatusAttr)
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
uuid: "18",
alias: "2"
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
uuid: "19"
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.getFoliosAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosAggr.countOut), asPrimitiveValue(model.variables.getFoliosAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFoliosAggr.listOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "FoliosList",
functionKey: "7ab34bf4-69ef-4560-8785-0186c464d342",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.FoliosList",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
