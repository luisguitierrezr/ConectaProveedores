namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3PTdL4jnkkyDYEXjFWaoNw)
///  <code>RC_9f9ef21ffaabef46bdddd7ca965685a7</code> that represents <code>UserFolioLogRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserFolioLogRecord
public partial struct RC_9f9ef21ffaabef46bdddd7ca965685a7 : ITypedRecord<RC_9f9ef21ffaabef46bdddd7ca965685a7> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4q_F0TKorVCOJU710qKbAQ");

public ENUserEntityRecord ssENUser;

public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord ssENFolioLog;


public BitArray OptimizedAttributes;

public RC_9f9ef21ffaabef46bdddd7ca965685a7() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioLog = new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioLog.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioLog.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioLog.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
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
public void ReadIM(RC_9f9ef21ffaabef46bdddd7ca965685a7 r) {
this = r;
}


public static bool operator == (RC_9f9ef21ffaabef46bdddd7ca965685a7 a, RC_9f9ef21ffaabef46bdddd7ca965685a7 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioLog != b.ssENFolioLog) return false;
return true;
}

public static bool operator != (RC_9f9ef21ffaabef46bdddd7ca965685a7 a, RC_9f9ef21ffaabef46bdddd7ca965685a7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9f9ef21ffaabef46bdddd7ca965685a7)) return false;
return (this == (RC_9f9ef21ffaabef46bdddd7ca965685a7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolioLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioLog.InternalRecursiveSave();
}


public RC_9f9ef21ffaabef46bdddd7ca965685a7 Duplicate() {
RC_9f9ef21ffaabef46bdddd7ca965685a7 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "foliolog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioLog")) variable.Value = ssENFolioLog; else variable.Optimized = true;
variable.SetFieldName("foliolog");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdFolioLog) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdFolioLog.Key.AsGuid) {
return ssENFolioLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioLog.FillFromOther((IRecord) other.AttributeGet(IdFolioLog));
}
} // RC_9f9ef21ffaabef46bdddd7ca965685a7
/// <summary>
/// RecordList type <code>UserFolioLogRecordList</code> that represents a record list of <code>User,
///  FolioLog</code>
/// </summary>
public partial class RL_4f2c6ead1defc6a22d01e9202d23be15 : GenericRecordList<RC_9f9ef21ffaabef46bdddd7ca965685a7>, IEnumerable, IEnumerator {

protected override RC_9f9ef21ffaabef46bdddd7ca965685a7 GetElementDefaultValue() {
return new RC_9f9ef21ffaabef46bdddd7ca965685a7();
}

public T[] ToArray<T>(Func<RC_9f9ef21ffaabef46bdddd7ca965685a7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f2c6ead1defc6a22d01e9202d23be15 recordList, Func<RC_9f9ef21ffaabef46bdddd7ca965685a7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f2c6ead1defc6a22d01e9202d23be15(RC_9f9ef21ffaabef46bdddd7ca965685a7[] array) {
  RL_4f2c6ead1defc6a22d01e9202d23be15 result = new RL_4f2c6ead1defc6a22d01e9202d23be15();
result.InnerFromArray(array);
    return result;
}

public static RL_4f2c6ead1defc6a22d01e9202d23be15 ToList<T>(T[] array, Func <T, RC_9f9ef21ffaabef46bdddd7ca965685a7> converter) {
  RL_4f2c6ead1defc6a22d01e9202d23be15 result = new RL_4f2c6ead1defc6a22d01e9202d23be15();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f2c6ead1defc6a22d01e9202d23be15 FromRestList<T>(RestList<T> restList, Func <T, RC_9f9ef21ffaabef46bdddd7ca965685a7> converter) {
  RL_4f2c6ead1defc6a22d01e9202d23be15 result = new RL_4f2c6ead1defc6a22d01e9202d23be15();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f2c6ead1defc6a22d01e9202d23be15() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9f9ef21ffaabef46bdddd7ca965685a7> NewList() {
return new RL_4f2c6ead1defc6a22d01e9202d23be15();
}


} // RL_4f2c6ead1defc6a22d01e9202d23be15
}

