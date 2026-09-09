namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_CECO_COSMOZ_Response_Struct (OLaVDjMkUUaISANR2oBA8g)
///  <code>ST_b6cef14925f799164fc3167fe695008bStructure</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Response_Struct</code> <p>Description:
///  EM_SM_CECO_COSMOZ_Response_Struct</p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Response_Struct
public partial struct ST_b6cef14925f799164fc3167fe695008bStructure : ITypedRecord<ST_b6cef14925f799164fc3167fe695008bStructure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*5B8cEQiRHkmFEUf9_c8JrQ");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*gKcTHPv2xEaMSWoo3YVcdg");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*FDxvlrUC70GbK4ET8U1BCg");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*2KrO4lUGfkKHId+lNSRF1w");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*0ZGmARXBPEiLZrwxM+Htng");
internal static readonly GlobalObjectKey IdPO_FOLIO_AGRUPADOS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*xgG5Kvm6PEycNSbT_5pxXQ");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*k7MTsNmH+EKGjPo_YUHMGA");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*4jmo_BwcaUeRNgpH6GrOtw");

public string ssPO_DESCRIPCION_ERROR;

public string ssPO_DOCUMENTO_MATERIAL_EM;

public string ssPO_DOCUMENTO_MATERIAL_SM;

public string ssPO_EJERCICIO_EM;

public string ssPO_EJERCICIO_SM;

public string ssPO_FOLIO_AGRUPADOS;

public string ssPO_NUMERO_ERROR;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_b6cef14925f799164fc3167fe695008bStructure() {
OptimizedAttributes = null;
ssPO_DESCRIPCION_ERROR = "";
ssPO_DOCUMENTO_MATERIAL_EM = "";
ssPO_DOCUMENTO_MATERIAL_SM = "";
ssPO_EJERCICIO_EM = "";
ssPO_EJERCICIO_SM = "";
ssPO_FOLIO_AGRUPADOS = "";
ssPO_NUMERO_ERROR = "";
ssPO_RESULTADO = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_DESCRIPCION_ERROR", "");
ssPO_DOCUMENTO_MATERIAL_EM = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_EM", "");
ssPO_DOCUMENTO_MATERIAL_SM = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_SM", "");
ssPO_EJERCICIO_EM = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_EJERCICIO_EM", "");
ssPO_EJERCICIO_SM = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_EJERCICIO_SM", "");
ssPO_FOLIO_AGRUPADOS = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_FOLIO_AGRUPADOS", "");
ssPO_NUMERO_ERROR = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_NUMERO_ERROR", "");
ssPO_RESULTADO = r.ReadText(index++, "EM_SM_CECO_COSMOZ_Response_Struct.PO_RESULTADO", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_b6cef14925f799164fc3167fe695008bStructure r) {
this = r;
}


public static bool operator == (ST_b6cef14925f799164fc3167fe695008bStructure a, ST_b6cef14925f799164fc3167fe695008bStructure b) {
if (a.ssPO_DESCRIPCION_ERROR != b.ssPO_DESCRIPCION_ERROR) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_EM != b.ssPO_DOCUMENTO_MATERIAL_EM) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_SM != b.ssPO_DOCUMENTO_MATERIAL_SM) return false;
if (a.ssPO_EJERCICIO_EM != b.ssPO_EJERCICIO_EM) return false;
if (a.ssPO_EJERCICIO_SM != b.ssPO_EJERCICIO_SM) return false;
if (a.ssPO_FOLIO_AGRUPADOS != b.ssPO_FOLIO_AGRUPADOS) return false;
if (a.ssPO_NUMERO_ERROR != b.ssPO_NUMERO_ERROR) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
return true;
}

public static bool operator != (ST_b6cef14925f799164fc3167fe695008bStructure a, ST_b6cef14925f799164fc3167fe695008bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b6cef14925f799164fc3167fe695008bStructure)) return false;
return (this == (ST_b6cef14925f799164fc3167fe695008bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_DESCRIPCION_ERROR.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_EM.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_SM.GetHashCode()
 ^ ssPO_EJERCICIO_EM.GetHashCode()
 ^ ssPO_EJERCICIO_SM.GetHashCode()
 ^ ssPO_FOLIO_AGRUPADOS.GetHashCode()
 ^ ssPO_NUMERO_ERROR.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b6cef14925f799164fc3167fe695008bStructure Duplicate() {
ST_b6cef14925f799164fc3167fe695008bStructure t;
t.ssPO_DESCRIPCION_ERROR = this.ssPO_DESCRIPCION_ERROR;
t.ssPO_DOCUMENTO_MATERIAL_EM = this.ssPO_DOCUMENTO_MATERIAL_EM;
t.ssPO_DOCUMENTO_MATERIAL_SM = this.ssPO_DOCUMENTO_MATERIAL_SM;
t.ssPO_EJERCICIO_EM = this.ssPO_EJERCICIO_EM;
t.ssPO_EJERCICIO_SM = this.ssPO_EJERCICIO_SM;
t.ssPO_FOLIO_AGRUPADOS = this.ssPO_FOLIO_AGRUPADOS;
t.ssPO_NUMERO_ERROR = this.ssPO_NUMERO_ERROR;
t.ssPO_RESULTADO = this.ssPO_RESULTADO;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "po_descripcion_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DESCRIPCION_ERROR")) variable.Value = ssPO_DESCRIPCION_ERROR; else variable.Optimized = true;
} else if (head == "po_documento_material_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_EM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_EM; else variable.Optimized = true;
} else if (head == "po_documento_material_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_SM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_SM; else variable.Optimized = true;
} else if (head == "po_ejercicio_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_EM")) variable.Value = ssPO_EJERCICIO_EM; else variable.Optimized = true;
} else if (head == "po_ejercicio_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_SM")) variable.Value = ssPO_EJERCICIO_SM; else variable.Optimized = true;
} else if (head == "po_folio_agrupados") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_FOLIO_AGRUPADOS")) variable.Value = ssPO_FOLIO_AGRUPADOS; else variable.Optimized = true;
} else if (head == "po_numero_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUMERO_ERROR")) variable.Value = ssPO_NUMERO_ERROR; else variable.Optimized = true;
} else if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPO_DESCRIPCION_ERROR) {
return ssPO_DESCRIPCION_ERROR;
}
if (key == IdPO_DOCUMENTO_MATERIAL_EM) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (key == IdPO_DOCUMENTO_MATERIAL_SM) {
return ssPO_DOCUMENTO_MATERIAL_SM;
}
if (key == IdPO_EJERCICIO_EM) {
return ssPO_EJERCICIO_EM;
}
if (key == IdPO_EJERCICIO_SM) {
return ssPO_EJERCICIO_SM;
}
if (key == IdPO_FOLIO_AGRUPADOS) {
return ssPO_FOLIO_AGRUPADOS;
}
if (key == IdPO_NUMERO_ERROR) {
return ssPO_NUMERO_ERROR;
}
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_DESCRIPCION_ERROR.Key.AsGuid) {
return ssPO_DESCRIPCION_ERROR;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_EM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_SM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_SM;
}
if (attributeKey == IdPO_EJERCICIO_EM.Key.AsGuid) {
return ssPO_EJERCICIO_EM;
}
if (attributeKey == IdPO_EJERCICIO_SM.Key.AsGuid) {
return ssPO_EJERCICIO_SM;
}
if (attributeKey == IdPO_FOLIO_AGRUPADOS.Key.AsGuid) {
return ssPO_FOLIO_AGRUPADOS;
}
if (attributeKey == IdPO_NUMERO_ERROR.Key.AsGuid) {
return ssPO_NUMERO_ERROR;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_DESCRIPCION_ERROR = (string) other.AttributeGet(IdPO_DESCRIPCION_ERROR);
ssPO_DOCUMENTO_MATERIAL_EM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
ssPO_DOCUMENTO_MATERIAL_SM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_SM);
ssPO_EJERCICIO_EM = (string) other.AttributeGet(IdPO_EJERCICIO_EM);
ssPO_EJERCICIO_SM = (string) other.AttributeGet(IdPO_EJERCICIO_SM);
ssPO_FOLIO_AGRUPADOS = (string) other.AttributeGet(IdPO_FOLIO_AGRUPADOS);
ssPO_NUMERO_ERROR = (string) other.AttributeGet(IdPO_NUMERO_ERROR);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
}
} // ST_b6cef14925f799164fc3167fe695008bStructure
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_Response_StructList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_97cf0d0e06581de35cff07449670d73f : GenericRecordList<ST_b6cef14925f799164fc3167fe695008bStructure>, IEnumerable, IEnumerator {

protected override ST_b6cef14925f799164fc3167fe695008bStructure GetElementDefaultValue() {
return new ST_b6cef14925f799164fc3167fe695008bStructure();
}

public T[] ToArray<T>(Func<ST_b6cef14925f799164fc3167fe695008bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_97cf0d0e06581de35cff07449670d73f recordList, Func<ST_b6cef14925f799164fc3167fe695008bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_97cf0d0e06581de35cff07449670d73f(ST_b6cef14925f799164fc3167fe695008bStructure[] array) {
  RL_97cf0d0e06581de35cff07449670d73f result = new RL_97cf0d0e06581de35cff07449670d73f();
result.InnerFromArray(array);
    return result;
}

public static RL_97cf0d0e06581de35cff07449670d73f ToList<T>(T[] array, Func <T, ST_b6cef14925f799164fc3167fe695008bStructure> converter) {
  RL_97cf0d0e06581de35cff07449670d73f result = new RL_97cf0d0e06581de35cff07449670d73f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_97cf0d0e06581de35cff07449670d73f FromRestList<T>(RestList<T> restList, Func <T, ST_b6cef14925f799164fc3167fe695008bStructure> converter) {
  RL_97cf0d0e06581de35cff07449670d73f result = new RL_97cf0d0e06581de35cff07449670d73f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_97cf0d0e06581de35cff07449670d73f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b6cef14925f799164fc3167fe695008bStructure> NewList() {
return new RL_97cf0d0e06581de35cff07449670d73f();
}


} // RL_97cf0d0e06581de35cff07449670d73f
}

