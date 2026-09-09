namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (K6Ahazhz4U6E5WzFEe_WXQ)
///  <code>RC_6e09c12efbeb44db58e002e7a26051ab</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Response_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Response_StructRecord
public partial struct RC_6e09c12efbeb44db58e002e7a26051ab : ITypedRecord<RC_6e09c12efbeb44db58e002e7a26051ab> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Response_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LsEJbuv720RY4ALnomBRqw");

public ST_b6cef14925f799164fc3167fe695008bStructure ssSTEM_SM_CECO_COSMOZ_Response_Struct;


public static implicit operator ST_b6cef14925f799164fc3167fe695008bStructure( RC_6e09c12efbeb44db58e002e7a26051ab r) {
return r.ssSTEM_SM_CECO_COSMOZ_Response_Struct;
}

public static implicit operator RC_6e09c12efbeb44db58e002e7a26051ab (ST_b6cef14925f799164fc3167fe695008bStructure r) {
RC_6e09c12efbeb44db58e002e7a26051ab res = new RC_6e09c12efbeb44db58e002e7a26051ab ();
res.ssSTEM_SM_CECO_COSMOZ_Response_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6e09c12efbeb44db58e002e7a26051ab() {
OptimizedAttributes = null;
ssSTEM_SM_CECO_COSMOZ_Response_Struct = new ST_b6cef14925f799164fc3167fe695008bStructure();
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
    ssSTEM_SM_CECO_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_CECO_COSMOZ_Response_Struct.Read( r, ref index);
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
public void ReadIM(RC_6e09c12efbeb44db58e002e7a26051ab r) {
this = r;
}


public static bool operator == (RC_6e09c12efbeb44db58e002e7a26051ab a, RC_6e09c12efbeb44db58e002e7a26051ab b) {
if (a.ssSTEM_SM_CECO_COSMOZ_Response_Struct != b.ssSTEM_SM_CECO_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (RC_6e09c12efbeb44db58e002e7a26051ab a, RC_6e09c12efbeb44db58e002e7a26051ab b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6e09c12efbeb44db58e002e7a26051ab)) return false;
return (this == (RC_6e09c12efbeb44db58e002e7a26051ab)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_CECO_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_CECO_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_CECO_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public RC_6e09c12efbeb44db58e002e7a26051ab Duplicate() {
RC_6e09c12efbeb44db58e002e7a26051ab t;
t.ssSTEM_SM_CECO_COSMOZ_Response_Struct = (ST_b6cef14925f799164fc3167fe695008bStructure)this.ssSTEM_SM_CECO_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Response_Struct")) variable.Value = ssSTEM_SM_CECO_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_response_struct");
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
if (key == IdEM_SM_CECO_COSMOZ_Response_Struct) {
return ssSTEM_SM_CECO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Response_Struct.Key.AsGuid) {
return ssSTEM_SM_CECO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_CECO_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Response_Struct));
}
} // RC_6e09c12efbeb44db58e002e7a26051ab
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_Response_StructRecordList</code> that represents a record
///  list of <code>EM_SM_CECO_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_dbc843aa8a5cc1c4722c9a3377427d00 : GenericRecordList<RC_6e09c12efbeb44db58e002e7a26051ab>, IEnumerable, IEnumerator {

protected override RC_6e09c12efbeb44db58e002e7a26051ab GetElementDefaultValue() {
return new RC_6e09c12efbeb44db58e002e7a26051ab();
}

public T[] ToArray<T>(Func<RC_6e09c12efbeb44db58e002e7a26051ab, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dbc843aa8a5cc1c4722c9a3377427d00 recordList, Func<RC_6e09c12efbeb44db58e002e7a26051ab, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dbc843aa8a5cc1c4722c9a3377427d00(RC_6e09c12efbeb44db58e002e7a26051ab[] array) {
  RL_dbc843aa8a5cc1c4722c9a3377427d00 result = new RL_dbc843aa8a5cc1c4722c9a3377427d00();
result.InnerFromArray(array);
    return result;
}

public static RL_dbc843aa8a5cc1c4722c9a3377427d00 ToList<T>(T[] array, Func <T, RC_6e09c12efbeb44db58e002e7a26051ab> converter) {
  RL_dbc843aa8a5cc1c4722c9a3377427d00 result = new RL_dbc843aa8a5cc1c4722c9a3377427d00();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dbc843aa8a5cc1c4722c9a3377427d00 FromRestList<T>(RestList<T> restList, Func <T, RC_6e09c12efbeb44db58e002e7a26051ab> converter) {
  RL_dbc843aa8a5cc1c4722c9a3377427d00 result = new RL_dbc843aa8a5cc1c4722c9a3377427d00();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dbc843aa8a5cc1c4722c9a3377427d00() : base() {
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
protected override OSList<RC_6e09c12efbeb44db58e002e7a26051ab> NewList() {
return new RL_dbc843aa8a5cc1c4722c9a3377427d00();
}


} // RL_dbc843aa8a5cc1c4722c9a3377427d00
}

