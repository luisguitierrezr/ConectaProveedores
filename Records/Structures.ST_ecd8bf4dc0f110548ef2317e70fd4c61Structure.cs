namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_SM_CECO_COSMOZREsp (MOKof5QA_02bgZOjqm0ltg)
///  <code>ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure</code> that represent
/// s <code>ZMXMIMMF_EM_SM_CECO_COSMOZREsp</code> <p>Description: ZMXMIMMF_EM_SM_CECO_COSMOZREsp</p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_CECO_COSMOZREsp
public partial struct ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure : ITypedRecord<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*TeUYy3mGXU2mxWK5cFi_tw");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*0Dm7FUzIh0iiyP3UPjlQ6A");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*untWAdVdgk+3hlUJp3oX0g");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NKlQXCUW5kq1HeM+ieHPhw");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*7ndtNh1_t0uwb+fKn_vqXw");
internal static readonly GlobalObjectKey IdPO_FOLIO_AGRUPADOS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*TdVYi+VHSkqAOQNchse0Uw");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*B+n8qnXr+kWYZVGQuUjaIQ");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*vmvbK16NjkiNJdZhXlCoZA");

public string ssPO_DESCRIPCION_ERROR;

public string ssPO_DOCUMENTO_MATERIAL_EM;

public string ssPO_DOCUMENTO_MATERIAL_SM;

public string ssPO_EJERCICIO_EM;

public string ssPO_EJERCICIO_SM;

public string ssPO_FOLIO_AGRUPADOS;

public string ssPO_NUMERO_ERROR;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure() {
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
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_DESCRIPCION_ERROR", "");
ssPO_DOCUMENTO_MATERIAL_EM = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_DOCUMENTO_MATERIAL_EM", "");
ssPO_DOCUMENTO_MATERIAL_SM = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_DOCUMENTO_MATERIAL_SM", "");
ssPO_EJERCICIO_EM = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_EJERCICIO_EM", "");
ssPO_EJERCICIO_SM = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_EJERCICIO_SM", "");
ssPO_FOLIO_AGRUPADOS = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_FOLIO_AGRUPADOS", "");
ssPO_NUMERO_ERROR = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_NUMERO_ERROR", "");
ssPO_RESULTADO = r.ReadText(index++, "ZMXMIMMF_EM_SM_CECO_COSMOZREsp.PO_RESULTADO", "");
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
public void ReadIM(ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure r) {
this = r;
}


public static bool operator == (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure a, ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure b) {
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

public static bool operator != (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure a, ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure)) return false;
return (this == (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure)o);
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


public ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure Duplicate() {
ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure t;
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
} // ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_CECO_COSMOZREspList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_CECO_COSMOZREsp</code>
/// </summary>
public partial class RL_e2fe70de72a1337ab52eb247809769e2 : GenericRecordList<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure>, IEnumerable, IEnumerator {

protected override ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure GetElementDefaultValue() {
return new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure();
}

public T[] ToArray<T>(Func<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2fe70de72a1337ab52eb247809769e2 recordList, Func<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2fe70de72a1337ab52eb247809769e2(ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure[] array) {
  RL_e2fe70de72a1337ab52eb247809769e2 result = new RL_e2fe70de72a1337ab52eb247809769e2();
result.InnerFromArray(array);
    return result;
}

public static RL_e2fe70de72a1337ab52eb247809769e2 ToList<T>(T[] array, Func <T, ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> converter) {
  RL_e2fe70de72a1337ab52eb247809769e2 result = new RL_e2fe70de72a1337ab52eb247809769e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2fe70de72a1337ab52eb247809769e2 FromRestList<T>(RestList<T> restList, Func <T, ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> converter) {
  RL_e2fe70de72a1337ab52eb247809769e2 result = new RL_e2fe70de72a1337ab52eb247809769e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2fe70de72a1337ab52eb247809769e2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> NewList() {
return new RL_e2fe70de72a1337ab52eb247809769e2();
}


} // RL_e2fe70de72a1337ab52eb247809769e2
}

