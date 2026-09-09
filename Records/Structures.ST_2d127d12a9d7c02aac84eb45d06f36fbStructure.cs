namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] DirectoryRole (RbJ1Yb4fDkOzVAimBcrnDQ)
///  <code>ST_2d127d12a9d7c02aac84eb45d06f36fbStructure</code> that represent
/// s <code>DirectoryRole</code> <p>Description: </p>
/// </summary>
// Name: DirectoryRole
public partial struct ST_2d127d12a9d7c02aac84eb45d06f36fbStructure : ITypedRecord<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure> {
internal static readonly GlobalObjectKey Idodata_context = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*dJ8HyJFYJ0uikBXUs90kog");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*plsK+oAGEEO_uyxmP6iApg");

public string ssodata_context;

public RL_02734d484762896f3a74099335d4c25d ssValue;


public BitArray OptimizedAttributes;

public ST_2d127d12a9d7c02aac84eb45d06f36fbStructure() {
OptimizedAttributes = null;
ssodata_context = "";
ssValue = new RL_02734d484762896f3a74099335d4c25d();
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
ssodata_context = r.ReadText(index++, "DirectoryRole.odata_context", "");
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
public void ReadIM(ST_2d127d12a9d7c02aac84eb45d06f36fbStructure r) {
this = r;
}


public static bool operator == (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure a, ST_2d127d12a9d7c02aac84eb45d06f36fbStructure b) {
if (a.ssodata_context != b.ssodata_context) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure a, ST_2d127d12a9d7c02aac84eb45d06f36fbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure)) return false;
return (this == (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssodata_context.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssValue.RecursiveReset();
}

public void InternalRecursiveSave() {
ssValue.InternalRecursiveSave();
}


public ST_2d127d12a9d7c02aac84eb45d06f36fbStructure Duplicate() {
ST_2d127d12a9d7c02aac84eb45d06f36fbStructure t;
t.ssodata_context = this.ssodata_context;
t.ssValue = (RL_02734d484762896f3a74099335d4c25d)this.ssValue.Duplicate();
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
if (head == "odata_context") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".odata_context")) variable.Value = ssodata_context; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
variable.SetFieldName("value");
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
if (key == Idodata_context) {
return ssodata_context;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idodata_context.Key.AsGuid) {
return ssodata_context;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssodata_context = (string) other.AttributeGet(Idodata_context);
ssValue = new RL_02734d484762896f3a74099335d4c25d();
ssValue.FillFromOther((IOSList) other.AttributeGet(IdValue));
}
} // ST_2d127d12a9d7c02aac84eb45d06f36fbStructure
/// <summary>
/// RecordList type <code>DirectoryRoleList</code> that represents a record list of
///  <code>DirectoryRole</code>
/// </summary>
public partial class RL_43e3ff5676e18ab7ad1e60fccf2a9d6e : GenericRecordList<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure>, IEnumerable, IEnumerator {

protected override ST_2d127d12a9d7c02aac84eb45d06f36fbStructure GetElementDefaultValue() {
return new ST_2d127d12a9d7c02aac84eb45d06f36fbStructure();
}

public T[] ToArray<T>(Func<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43e3ff5676e18ab7ad1e60fccf2a9d6e recordList, Func<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43e3ff5676e18ab7ad1e60fccf2a9d6e(ST_2d127d12a9d7c02aac84eb45d06f36fbStructure[] array) {
  RL_43e3ff5676e18ab7ad1e60fccf2a9d6e result = new RL_43e3ff5676e18ab7ad1e60fccf2a9d6e();
result.InnerFromArray(array);
    return result;
}

public static RL_43e3ff5676e18ab7ad1e60fccf2a9d6e ToList<T>(T[] array, Func <T, ST_2d127d12a9d7c02aac84eb45d06f36fbStructure> converter) {
  RL_43e3ff5676e18ab7ad1e60fccf2a9d6e result = new RL_43e3ff5676e18ab7ad1e60fccf2a9d6e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43e3ff5676e18ab7ad1e60fccf2a9d6e FromRestList<T>(RestList<T> restList, Func <T, ST_2d127d12a9d7c02aac84eb45d06f36fbStructure> converter) {
  RL_43e3ff5676e18ab7ad1e60fccf2a9d6e result = new RL_43e3ff5676e18ab7ad1e60fccf2a9d6e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43e3ff5676e18ab7ad1e60fccf2a9d6e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure> NewList() {
return new RL_43e3ff5676e18ab7ad1e60fccf2a9d6e();
}


} // RL_43e3ff5676e18ab7ad1e60fccf2a9d6e
}

