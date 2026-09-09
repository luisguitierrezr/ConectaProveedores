namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Tp_m_LT10UCp4_6WiFuSFw)
///  <code>RC_d1c5afe2a83250ad8e254ef5d2a29b01</code> that represents <code>FolioLogRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioLogRecord
public partial struct RC_d1c5afe2a83250ad8e254ef5d2a29b01 : ITypedRecord<RC_d1c5afe2a83250ad8e254ef5d2a29b01> {
internal static readonly GlobalObjectKey IdFolioLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4q_F0TKorVCOJU710qKbAQ");

public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord ssENFolioLog;


public static implicit operator EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord( RC_d1c5afe2a83250ad8e254ef5d2a29b01 r) {
return r.ssENFolioLog;
}

public static implicit operator RC_d1c5afe2a83250ad8e254ef5d2a29b01 (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord r) {
RC_d1c5afe2a83250ad8e254ef5d2a29b01 res = new RC_d1c5afe2a83250ad8e254ef5d2a29b01 ();
res.ssENFolioLog = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioLog.ChangedAttributes = value;
}
get {
    return ssENFolioLog.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d1c5afe2a83250ad8e254ef5d2a29b01() {
OptimizedAttributes = null;
ssENFolioLog = new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioLog.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioLog.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioLog.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioLog.Read( r, ref index);
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
public void ReadIM(RC_d1c5afe2a83250ad8e254ef5d2a29b01 r) {
this = r;
}


public static bool operator == (RC_d1c5afe2a83250ad8e254ef5d2a29b01 a, RC_d1c5afe2a83250ad8e254ef5d2a29b01 b) {
if (a.ssENFolioLog != b.ssENFolioLog) return false;
return true;
}

public static bool operator != (RC_d1c5afe2a83250ad8e254ef5d2a29b01 a, RC_d1c5afe2a83250ad8e254ef5d2a29b01 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d1c5afe2a83250ad8e254ef5d2a29b01)) return false;
return (this == (RC_d1c5afe2a83250ad8e254ef5d2a29b01)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioLog.InternalRecursiveSave();
}


public RC_d1c5afe2a83250ad8e254ef5d2a29b01 Duplicate() {
RC_d1c5afe2a83250ad8e254ef5d2a29b01 t;
t.ssENFolioLog = (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord)this.ssENFolioLog.Duplicate();
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
if (head == "foliolog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioLog")) variable.Value = ssENFolioLog; else variable.Optimized = true;
variable.SetFieldName("foliolog");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioLog.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioLog.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioLog) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioLog.Key.AsGuid) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioLog.FillFromOther((IRecord) other.AttributeGet(IdFolioLog));
}
} // RC_d1c5afe2a83250ad8e254ef5d2a29b01
/// <summary>
/// RecordList type <code>FolioLogRecordList</code> that represents a record list of
///  <code>FolioLog</code>
/// </summary>
public partial class RL_7378b9f1001bf074e0efe8ad3a432970 : GenericRecordList<RC_d1c5afe2a83250ad8e254ef5d2a29b01>, IEnumerable, IEnumerator {

protected override RC_d1c5afe2a83250ad8e254ef5d2a29b01 GetElementDefaultValue() {
return new RC_d1c5afe2a83250ad8e254ef5d2a29b01();
}

public T[] ToArray<T>(Func<RC_d1c5afe2a83250ad8e254ef5d2a29b01, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7378b9f1001bf074e0efe8ad3a432970 recordList, Func<RC_d1c5afe2a83250ad8e254ef5d2a29b01, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7378b9f1001bf074e0efe8ad3a432970(RC_d1c5afe2a83250ad8e254ef5d2a29b01[] array) {
  RL_7378b9f1001bf074e0efe8ad3a432970 result = new RL_7378b9f1001bf074e0efe8ad3a432970();
result.InnerFromArray(array);
    return result;
}

public static RL_7378b9f1001bf074e0efe8ad3a432970 ToList<T>(T[] array, Func <T, RC_d1c5afe2a83250ad8e254ef5d2a29b01> converter) {
  RL_7378b9f1001bf074e0efe8ad3a432970 result = new RL_7378b9f1001bf074e0efe8ad3a432970();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7378b9f1001bf074e0efe8ad3a432970 FromRestList<T>(RestList<T> restList, Func <T, RC_d1c5afe2a83250ad8e254ef5d2a29b01> converter) {
  RL_7378b9f1001bf074e0efe8ad3a432970 result = new RL_7378b9f1001bf074e0efe8ad3a432970();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7378b9f1001bf074e0efe8ad3a432970() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d1c5afe2a83250ad8e254ef5d2a29b01> NewList() {
return new RL_7378b9f1001bf074e0efe8ad3a432970();
}


} // RL_7378b9f1001bf074e0efe8ad3a432970
}

