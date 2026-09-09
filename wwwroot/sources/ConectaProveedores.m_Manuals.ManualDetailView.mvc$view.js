import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Icon as OSWidgets$Icon, AdvancedHtml as OSWidgets$AdvancedHtml, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { ST_6510d2524fe77fcc6c285159d4000cfbStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_Video_mvc_view from "./OutSystemsUI.Interaction.Video.mvc$view.js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$view.js";
import ModelFactory from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getManualByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-header",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-title",
visible: true,
_idProps: {
service: idService,
uuid: "2"
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
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.titleAttr,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManualByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cerrarOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-body",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-shortdesc",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.shortDescriptionAttr,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManualByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-description",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManualByIdAggr.dataFetchStatusAttr)
}))), $if(((OS$BuiltinFunctions.trim(model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualFileAttr.videoLinkAttr)) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_Video_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("bPu7sfkSuUaKLMAvlXuP+A.OptionalConfigs"), function () {
return function () {
var rec = new ST_6510d2524fe77fcc6c285159d4000cfbStructure();
rec.autoplayAttr = false;
rec.loopAttr = true;
rec.mutedAttr = true;
return rec;
}();
}),
Width: "900",
URL: model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualFileAttr.videoLinkAttr,
_uRLInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManualByIdAggr.dataFetchStatusAttr)
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
uuid: "14",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [$if(model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.isVideoAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
style: "max-width: 100%;"
},
tag: "video",
_idProps: {
service: idService,
name: "myVideo"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "50vh",
PDFBinary: model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualFileAttr.fileAttr,
_pDFBinaryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManualByIdAggr.dataFetchStatusAttr)
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
uuid: "17",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "manual-popup-actions",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(OS$DataTypes.areBinaryNulls(model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualFileAttr.fileAttr, OS$BuiltinFunctions.nullBinary())) && (model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.isVideoAttr === false)), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.descargarOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "manual-popup-button",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Descargar")];
}, function () {
return [];
}), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cerrarOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "manual-popup-button secondary",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Cerrar")))];
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
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ManualDetailView",
functionKey: "b877fc0f-16b6-4f01-a53a-5fa888129679",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "m_Manuals.ManualDetailView",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.m_Manuals.ManualDetailView.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_Video_mvc_view, CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvc_view];
};


return ELEM;
};

export default componentFactory()
