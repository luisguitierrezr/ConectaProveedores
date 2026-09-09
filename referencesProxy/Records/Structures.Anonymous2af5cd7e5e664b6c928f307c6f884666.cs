namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (fs31KmZebEuSjzB8b4hGZg)
///  <code>RC_8a18f13d5e920f1ccdf5a8a3416c783c</code> that represent
/// s <code>User_PreferencesRecord</code> <p>Description: </p>
/// </summary>
// Name: User_PreferencesRecord
public partial struct RC_8a18f13d5e920f1ccdf5a8a3416c783c : ITypedRecord<RC_8a18f13d5e920f1ccdf5a8a3416c783c> {
internal static readonly GlobalObjectKey IdUser_Preferences = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PfEYipJeHA_N9aijQWx4PA");

public EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord ssENUser_Preferences;


public static implicit operator EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord( RC_8a18f13d5e920f1ccdf5a8a3416c783c r) {
return r.ssENUser_Preferences;
}

public static implicit operator RC_8a18f13d5e920f1ccdf5a8a3416c783c (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord r) {
RC_8a18f13d5e920f1ccdf5a8a3416c783c res = new RC_8a18f13d5e920f1ccdf5a8a3416c783c ();
res.ssENUser_Preferences = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUser_Preferences.ChangedAttributes = value;
}
get {
    return ssENUser_Preferences.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8a18f13d5e920f1ccdf5a8a3416c783c() {
OptimizedAttributes = null;
ssENUser_Preferences = new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Preferences.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUser_Preferences.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUser_Preferences.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Preferences.Read( r, ref index);
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
public void ReadIM(RC_8a18f13d5e920f1ccdf5a8a3416c783c r) {
this = r;
}


public static bool operator == (RC_8a18f13d5e920f1ccdf5a8a3416c783c a, RC_8a18f13d5e920f1ccdf5a8a3416c783c b) {
if (a.ssENUser_Preferences != b.ssENUser_Preferences) return false;
return true;
}

public static bool operator != (RC_8a18f13d5e920f1ccdf5a8a3416c783c a, RC_8a18f13d5e920f1ccdf5a8a3416c783c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8a18f13d5e920f1ccdf5a8a3416c783c)) return false;
return (this == (RC_8a18f13d5e920f1ccdf5a8a3416c783c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Preferences.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Preferences.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Preferences.InternalRecursiveSave();
}


public RC_8a18f13d5e920f1ccdf5a8a3416c783c Duplicate() {
RC_8a18f13d5e920f1ccdf5a8a3416c783c t;
t.ssENUser_Preferences = (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord)this.ssENUser_Preferences.Duplicate();
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
if (head == "user_preferences") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Preferences")) variable.Value = ssENUser_Preferences; else variable.Optimized = true;
variable.SetFieldName("user_preferences");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUser_Preferences.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUser_Preferences.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUser_Preferences) {
return ssENUser_Preferences;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Preferences.Key.AsGuid) {
return ssENUser_Preferences;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Preferences.FillFromOther((IRecord) other.AttributeGet(IdUser_Preferences));
}
} // RC_8a18f13d5e920f1ccdf5a8a3416c783c
/// <summary>
/// RecordList type <code>User_PreferencesRecordList</code> that represents a record list of
///  <code>User_Preferences</code>
/// </summary>
public partial class RL_4d42067c3b4137865464e61ac342d126 : GenericRecordList<RC_8a18f13d5e920f1ccdf5a8a3416c783c>, IEnumerable, IEnumerator {

protected override RC_8a18f13d5e920f1ccdf5a8a3416c783c GetElementDefaultValue() {
return new RC_8a18f13d5e920f1ccdf5a8a3416c783c();
}

public T[] ToArray<T>(Func<RC_8a18f13d5e920f1ccdf5a8a3416c783c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d42067c3b4137865464e61ac342d126 recordList, Func<RC_8a18f13d5e920f1ccdf5a8a3416c783c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d42067c3b4137865464e61ac342d126(RC_8a18f13d5e920f1ccdf5a8a3416c783c[] array) {
  RL_4d42067c3b4137865464e61ac342d126 result = new RL_4d42067c3b4137865464e61ac342d126();
result.InnerFromArray(array);
    return result;
}

public static RL_4d42067c3b4137865464e61ac342d126 ToList<T>(T[] array, Func <T, RC_8a18f13d5e920f1ccdf5a8a3416c783c> converter) {
  RL_4d42067c3b4137865464e61ac342d126 result = new RL_4d42067c3b4137865464e61ac342d126();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d42067c3b4137865464e61ac342d126 FromRestList<T>(RestList<T> restList, Func <T, RC_8a18f13d5e920f1ccdf5a8a3416c783c> converter) {
  RL_4d42067c3b4137865464e61ac342d126 result = new RL_4d42067c3b4137865464e61ac342d126();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d42067c3b4137865464e61ac342d126() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8a18f13d5e920f1ccdf5a8a3416c783c> NewList() {
return new RL_4d42067c3b4137865464e61ac342d126();
}


} // RL_4d42067c3b4137865464e61ac342d126
}

