using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedRelations (NR3DGRW6w0mAm6N98EC+WQ)
///  <code>EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord</code> that represent
/// s <code>InvoiceExtendedRelations</code> <p>Description: Entity that holds Invoice Extended
///  Relations.</p>
/// </summary>
// Name: InvoiceExtendedRelations
public partial struct EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord : ITypedRecord<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Bnk7IkNTvkaXZ5CKrec4Rg");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0y4DPzfbXUapw0HFGcpJew");
internal static readonly GlobalObjectKey IdTipoRelacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7ajny1WgzEiyU+WC3XubWw");
internal static readonly GlobalObjectKey IdUUIDRelacionado = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m6qcIJpCxUeyrcnULkwYYg");
internal static readonly GlobalObjectKey IdFolioRelacionado = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yQu_QYyN3EiRc3dQJr4_QA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private string _ssTipoRelacion;
public string ssTipoRelacion{
  get{
      return _ssTipoRelacion;
  }
  set{
      if((_ssTipoRelacion!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTipoRelacion = value;
      }
  }
}

private string _ssUUIDRelacionado;
public string ssUUIDRelacionado{
  get{
      return _ssUUIDRelacionado;
  }
  set{
      if((_ssUUIDRelacionado!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssUUIDRelacionado = value;
      }
  }
}

private string _ssFolioRelacionado;
public string ssFolioRelacionado{
  get{
      return _ssFolioRelacionado;
  }
  set{
      if((_ssFolioRelacionado!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssFolioRelacionado = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssTipoRelacion = "";
_ssUUIDRelacionado = "";
_ssFolioRelacionado = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceExtendedRelations.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedRelations.InvoiceId", 0L);
ssTipoRelacion = r.ReadText(index++, "InvoiceExtendedRelations.TipoRelacion", "");
ssUUIDRelacionado = r.ReadText(index++, "InvoiceExtendedRelations.UUIDRelacionado", "");
ssFolioRelacionado = r.ReadText(index++, "InvoiceExtendedRelations.FolioRelacionado", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord r) {
this = r;
}


public static bool operator == (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord a, EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssTipoRelacion != b.ssTipoRelacion) return false;
if (a.ssUUIDRelacionado != b.ssUUIDRelacionado) return false;
if (a.ssFolioRelacionado != b.ssFolioRelacionado) return false;
return true;
}

public static bool operator != (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord a, EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord)) return false;
return (this == (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssTipoRelacion.GetHashCode()
 ^ ssUUIDRelacionado.GetHashCode()
 ^ ssFolioRelacionado.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord Duplicate() {
EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssTipoRelacion = this._ssTipoRelacion;
t._ssUUIDRelacionado = this._ssUUIDRelacionado;
t._ssFolioRelacionado = this._ssFolioRelacionado;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "tiporelacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TipoRelacion")) variable.Value = ssTipoRelacion; else variable.Optimized = true;
} else if (head == "uuidrelacionado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUIDRelacionado")) variable.Value = ssUUIDRelacionado; else variable.Optimized = true;
} else if (head == "foliorelacionado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioRelacionado")) variable.Value = ssFolioRelacionado; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTipoRelacion)) {
return ChangedAttributes[2];
}
if (key.Equals(IdUUIDRelacionado)) {
return ChangedAttributes[3];
}
if (key.Equals(IdFolioRelacionado)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTipoRelacion)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdUUIDRelacionado)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdFolioRelacionado)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdTipoRelacion) {
return ssTipoRelacion;
}
if (key == IdUUIDRelacionado) {
return ssUUIDRelacionado;
}
if (key == IdFolioRelacionado) {
return ssFolioRelacionado;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdTipoRelacion.Key.AsGuid) {
return ssTipoRelacion;
}
if (attributeKey == IdUUIDRelacionado.Key.AsGuid) {
return ssUUIDRelacionado;
}
if (attributeKey == IdFolioRelacionado.Key.AsGuid) {
return ssFolioRelacionado;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssTipoRelacion = (string) other.AttributeGet(IdTipoRelacion);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTipoRelacion);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTipoRelacion);
ssUUIDRelacionado = (string) other.AttributeGet(IdUUIDRelacionado);
ChangedAttributes[3] = other.ChangedAttributeGet(IdUUIDRelacionado);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUUIDRelacionado);
ssFolioRelacionado = (string) other.AttributeGet(IdFolioRelacionado);
ChangedAttributes[4] = other.ChangedAttributeGet(IdFolioRelacionado);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFolioRelacionado);
}
} // EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedRelationsList</code> that represents a record list of
///  <code>InvoiceExtendedRelations</code>
/// </summary>
public partial class RL_1801d41568a41cf6282486c389726e17 : GenericRecordList<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord>, IEnumerable, IEnumerator {

protected override EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord GetElementDefaultValue() {
return new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord();
}

public T[] ToArray<T>(Func<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1801d41568a41cf6282486c389726e17 recordList, Func<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1801d41568a41cf6282486c389726e17(EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord[] array) {
  RL_1801d41568a41cf6282486c389726e17 result = new RL_1801d41568a41cf6282486c389726e17();
result.InnerFromArray(array);
    return result;
}

public static RL_1801d41568a41cf6282486c389726e17 ToList<T>(T[] array, Func <T, EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> converter) {
  RL_1801d41568a41cf6282486c389726e17 result = new RL_1801d41568a41cf6282486c389726e17();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1801d41568a41cf6282486c389726e17 FromRestList<T>(RestList<T> restList, Func <T, EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> converter) {
  RL_1801d41568a41cf6282486c389726e17 result = new RL_1801d41568a41cf6282486c389726e17();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1801d41568a41cf6282486c389726e17() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> NewList() {
return new RL_1801d41568a41cf6282486c389726e17();
}


} // RL_1801d41568a41cf6282486c389726e17
}
