namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Q1yatvmHRkGEIyRwO3AWog)
///  <code>RC_abfc8474e8c0b6d4329c91f8949f80f9</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_ResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_ResponseRecord
public partial struct RC_abfc8474e8c0b6d4329c91f8949f80f9 : ITypedRecord<RC_abfc8474e8c0b6d4329c91f8949f80f9> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Response = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dIT8q8Do1LYynJH4lJ+A+Q");

public ST_92e975006ec90075480e9af34dc228e3Structure ssSTEM_SM_CECO_COSMOZ_Response;


public static implicit operator ST_92e975006ec90075480e9af34dc228e3Structure( RC_abfc8474e8c0b6d4329c91f8949f80f9 r) {
return r.ssSTEM_SM_CECO_COSMOZ_Response;
}

public static implicit operator RC_abfc8474e8c0b6d4329c91f8949f80f9 (ST_92e975006ec90075480e9af34dc228e3Structure r) {
RC_abfc8474e8c0b6d4329c91f8949f80f9 res = new RC_abfc8474e8c0b6d4329c91f8949f80f9 ();
res.ssSTEM_SM_CECO_COSMOZ_Response = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_abfc8474e8c0b6d4329c91f8949f80f9() {
OptimizedAttributes = null;
ssSTEM_SM_CECO_COSMOZ_Response = new ST_92e975006ec90075480e9af34dc228e3Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTEM_SM_CECO_COSMOZ_Response.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTEM_SM_CECO_COSMOZ_Response.Read( r, ref index);
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
public void ReadIM(RC_abfc8474e8c0b6d4329c91f8949f80f9 r) {
this = r;
}


public static bool operator == (RC_abfc8474e8c0b6d4329c91f8949f80f9 a, RC_abfc8474e8c0b6d4329c91f8949f80f9 b) {
if (a.ssSTEM_SM_CECO_COSMOZ_Response != b.ssSTEM_SM_CECO_COSMOZ_Response) return false;
return true;
}

public static bool operator != (RC_abfc8474e8c0b6d4329c91f8949f80f9 a, RC_abfc8474e8c0b6d4329c91f8949f80f9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_abfc8474e8c0b6d4329c91f8949f80f9)) return false;
return (this == (RC_abfc8474e8c0b6d4329c91f8949f80f9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_CECO_COSMOZ_Response.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_CECO_COSMOZ_Response.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_CECO_COSMOZ_Response.InternalRecursiveSave();
}


public RC_abfc8474e8c0b6d4329c91f8949f80f9 Duplicate() {
RC_abfc8474e8c0b6d4329c91f8949f80f9 t;
t.ssSTEM_SM_CECO_COSMOZ_Response = (ST_92e975006ec90075480e9af34dc228e3Structure)this.ssSTEM_SM_CECO_COSMOZ_Response.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_response") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Response")) variable.Value = ssSTEM_SM_CECO_COSMOZ_Response; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_response");
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
if (key == IdEM_SM_CECO_COSMOZ_Response) {
return ssSTEM_SM_CECO_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Response.Key.AsGuid) {
return ssSTEM_SM_CECO_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_CECO_COSMOZ_Response.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Response));
}
} // RC_abfc8474e8c0b6d4329c91f8949f80f9
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_ResponseRecordList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Response</code>
/// </summary>
public partial class RL_e0e6aa25712c1674832fd63944494a54 : GenericRecordList<RC_abfc8474e8c0b6d4329c91f8949f80f9>, IEnumerable, IEnumerator {

protected override RC_abfc8474e8c0b6d4329c91f8949f80f9 GetElementDefaultValue() {
return new RC_abfc8474e8c0b6d4329c91f8949f80f9();
}

public T[] ToArray<T>(Func<RC_abfc8474e8c0b6d4329c91f8949f80f9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e0e6aa25712c1674832fd63944494a54 recordList, Func<RC_abfc8474e8c0b6d4329c91f8949f80f9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e0e6aa25712c1674832fd63944494a54(RC_abfc8474e8c0b6d4329c91f8949f80f9[] array) {
  RL_e0e6aa25712c1674832fd63944494a54 result = new RL_e0e6aa25712c1674832fd63944494a54();
result.InnerFromArray(array);
    return result;
}

public static RL_e0e6aa25712c1674832fd63944494a54 ToList<T>(T[] array, Func <T, RC_abfc8474e8c0b6d4329c91f8949f80f9> converter) {
  RL_e0e6aa25712c1674832fd63944494a54 result = new RL_e0e6aa25712c1674832fd63944494a54();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e0e6aa25712c1674832fd63944494a54 FromRestList<T>(RestList<T> restList, Func <T, RC_abfc8474e8c0b6d4329c91f8949f80f9> converter) {
  RL_e0e6aa25712c1674832fd63944494a54 result = new RL_e0e6aa25712c1674832fd63944494a54();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e0e6aa25712c1674832fd63944494a54() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_abfc8474e8c0b6d4329c91f8949f80f9> NewList() {
return new RL_e0e6aa25712c1674832fd63944494a54();
}


} // RL_e0e6aa25712c1674832fd63944494a54
}

