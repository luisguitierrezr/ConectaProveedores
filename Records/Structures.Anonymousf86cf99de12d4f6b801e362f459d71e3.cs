namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nfls+C3ha0+AHjYvRZ1x4w)
///  <code>RC_7170c97aaf61dfa14af07f5ef3cecd45</code> that represent
/// s <code>UserIdRolenameUserNameRecord</code> <p>Description: </p>
/// </summary>
// Name: UserIdRolenameUserNameRecord
public partial struct RC_7170c97aaf61dfa14af07f5ef3cecd45 : ITypedRecord<RC_7170c97aaf61dfa14af07f5ef3cecd45> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7bYltFO7QFzcB1JfCLEFtw");
internal static readonly GlobalObjectKey IdRolename = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MTzSZReoY0z1P7RaNM4LGQ");
internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJrVOhuYo08aCWQeSpFJMA");

public string ssUserId;

public string ssRolename;

public string ssUserName;


public BitArray OptimizedAttributes;

public RC_7170c97aaf61dfa14af07f5ef3cecd45() {
OptimizedAttributes = null;
ssUserId = "";
ssRolename = "";
ssUserName = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "UserIdRolenameUserNameRecord.UserId", "");
ssRolename = r.ReadText(index++, "UserIdRolenameUserNameRecord.Rolename", "");
ssUserName = r.ReadText(index++, "UserIdRolenameUserNameRecord.UserName", "");
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
public void ReadIM(RC_7170c97aaf61dfa14af07f5ef3cecd45 r) {
this = r;
}


public static bool operator == (RC_7170c97aaf61dfa14af07f5ef3cecd45 a, RC_7170c97aaf61dfa14af07f5ef3cecd45 b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssRolename != b.ssRolename) return false;
if (a.ssUserName != b.ssUserName) return false;
return true;
}

public static bool operator != (RC_7170c97aaf61dfa14af07f5ef3cecd45 a, RC_7170c97aaf61dfa14af07f5ef3cecd45 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7170c97aaf61dfa14af07f5ef3cecd45)) return false;
return (this == (RC_7170c97aaf61dfa14af07f5ef3cecd45)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssRolename.GetHashCode()
 ^ ssUserName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_7170c97aaf61dfa14af07f5ef3cecd45 Duplicate() {
RC_7170c97aaf61dfa14af07f5ef3cecd45 t;
t.ssUserId = this.ssUserId;
t.ssRolename = this.ssRolename;
t.ssUserName = this.ssUserName;
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
if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "rolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Rolename")) variable.Value = ssRolename; else variable.Optimized = true;
} else if (head == "username") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserName")) variable.Value = ssUserName; else variable.Optimized = true;
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
if (key == IdUserId) {
return ssUserId;
}
if (key == IdRolename) {
return ssRolename;
}
if (key == IdUserName) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdRolename.Key.AsGuid) {
return ssRolename;
}
if (attributeKey == IdUserName.Key.AsGuid) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssRolename = (string) other.AttributeGet(IdRolename);
ssUserName = (string) other.AttributeGet(IdUserName);
}
} // RC_7170c97aaf61dfa14af07f5ef3cecd45
/// <summary>
/// RecordList type <code>UserIdRolenameUserNameRecordList</code> that represents a record list of
///  <code>UserIdentifier, Text, Text</code>
/// </summary>
public partial class RL_648f5b7a91b58d2f6ade938e7f17a9f2 : GenericRecordList<RC_7170c97aaf61dfa14af07f5ef3cecd45>, IEnumerable, IEnumerator {

protected override RC_7170c97aaf61dfa14af07f5ef3cecd45 GetElementDefaultValue() {
return new RC_7170c97aaf61dfa14af07f5ef3cecd45();
}

public T[] ToArray<T>(Func<RC_7170c97aaf61dfa14af07f5ef3cecd45, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_648f5b7a91b58d2f6ade938e7f17a9f2 recordList, Func<RC_7170c97aaf61dfa14af07f5ef3cecd45, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_648f5b7a91b58d2f6ade938e7f17a9f2(RC_7170c97aaf61dfa14af07f5ef3cecd45[] array) {
  RL_648f5b7a91b58d2f6ade938e7f17a9f2 result = new RL_648f5b7a91b58d2f6ade938e7f17a9f2();
result.InnerFromArray(array);
    return result;
}

public static RL_648f5b7a91b58d2f6ade938e7f17a9f2 ToList<T>(T[] array, Func <T, RC_7170c97aaf61dfa14af07f5ef3cecd45> converter) {
  RL_648f5b7a91b58d2f6ade938e7f17a9f2 result = new RL_648f5b7a91b58d2f6ade938e7f17a9f2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_648f5b7a91b58d2f6ade938e7f17a9f2 FromRestList<T>(RestList<T> restList, Func <T, RC_7170c97aaf61dfa14af07f5ef3cecd45> converter) {
  RL_648f5b7a91b58d2f6ade938e7f17a9f2 result = new RL_648f5b7a91b58d2f6ade938e7f17a9f2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_648f5b7a91b58d2f6ade938e7f17a9f2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7170c97aaf61dfa14af07f5ef3cecd45> NewList() {
return new RL_648f5b7a91b58d2f6ade938e7f17a9f2();
}


} // RL_648f5b7a91b58d2f6ade938e7f17a9f2
}

