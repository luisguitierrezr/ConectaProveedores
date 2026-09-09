import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Button as OSWidgets$Button, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Button, {
enabled: ((model.variables.fileJsonListIn) !== ("")),
gridProperties: {
classes: "ThemeGrid_Width2"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.linkOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-edit",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._fileJsonListInDataFetchStatus)
}, $text(getTranslation("9tQYbb7Fpk+TI9dzvhgoRg#Value", "Download all")), createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.linkOnClick$Action(controller.callContext(eventHandlerContext));
});
;
}
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_DownloadAllFolioFilesByFileList",
functionKey: "3359d2f2-566e-42fc-8584-73ad8de45414",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "s_Storage.wb_DownloadAllFolioFilesByFileList",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/ConectaProveedores.UserScripts.Zip.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
