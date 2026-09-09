namespace ssConectaProveedores {
/// <summary>
/// [Structure] FindUserByEmail (dEYAh1AM4kWrhuF8lJPAzQ)
///  <code>ST_f45a100349e05fd4d70690aea76ddd0aStructure</code> that represent
/// s <code>FindUserByEmail</code> <p>Description: </p>
/// </summary>
// Name: FindUserByEmail
public partial struct ST_f45a100349e05fd4d70690aea76ddd0aStructure : ITypedRecord<ST_f45a100349e05fd4d70690aea76ddd0aStructure> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LB_4MREoWkaFLCUnoF_64w");
internal static readonly GlobalObjectKey IdUserEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TvQb1ZPlAEmXJfAGNYjI0A");
internal static readonly GlobalObjectKey IdExtensionEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AjW2qdUb8k2VA+bgDKfrLQ");

public string ssUserId;

public string ssUserEmail;

public string ssExtensionEmail;


public BitArray OptimizedAttributes;

public ST_f45a100349e05fd4d70690aea76ddd0aStructure() {
OptimizedAttributes = null;
ssUserId = "";
ssUserEmail = "";
ssExtensionEmail = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "FindUserByEmail.UserId", "");
ssUserEmail = r.ReadText(index++, "FindUserByEmail.UserEmail", "");
ssExtensionEmail = r.ReadText(index++, "FindUserByEmail.ExtensionEmail", "");
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
public void ReadIM(ST_f45a100349e05fd4d70690aea76ddd0aStructure r) {
this = r;
}


public static bool operator == (ST_f45a100349e05fd4d70690aea76ddd0aStructure a, ST_f45a100349e05fd4d70690aea76ddd0aStructure b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssUserEmail != b.ssUserEmail) return false;
if (a.ssExtensionEmail != b.ssExtensionEmail) return false;
return true;
}

public static bool operator != (ST_f45a100349e05fd4d70690aea76ddd0aStructure a, ST_f45a100349e05fd4d70690aea76ddd0aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f45a100349e05fd4d70690aea76ddd0aStructure)) return false;
return (this == (ST_f45a100349e05fd4d70690aea76ddd0aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssUserEmail.GetHashCode()
 ^ ssExtensionEmail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f45a100349e05fd4d70690aea76ddd0aStructure Duplicate() {
ST_f45a100349e05fd4d70690aea76ddd0aStructure t;
t.ssUserId = this.ssUserId;
t.ssUserEmail = this.ssUserEmail;
t.ssExtensionEmail = this.ssExtensionEmail;
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
} else if (head == "useremail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserEmail")) variable.Value = ssUserEmail; else variable.Optimized = true;
} else if (head == "extensionemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtensionEmail")) variable.Value = ssExtensionEmail; else variable.Optimized = true;
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
if (key == IdUserEmail) {
return ssUserEmail;
}
if (key == IdExtensionEmail) {
return ssExtensionEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdUserEmail.Key.AsGuid) {
return ssUserEmail;
}
if (attributeKey == IdExtensionEmail.Key.AsGuid) {
return ssExtensionEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssUserEmail = (string) other.AttributeGet(IdUserEmail);
ssExtensionEmail = (string) other.AttributeGet(IdExtensionEmail);
}
} // ST_f45a100349e05fd4d70690aea76ddd0aStructure
/// <summary>
/// RecordList type <code>FindUserByEmailList</code> that represents a record list of
///  <code>FindUserByEmail</code>
/// </summary>
public partial class RL_1f2dce8131c11e514c7e3f0c7ba2a8ef : GenericRecordList<ST_f45a100349e05fd4d70690aea76ddd0aStructure>, IEnumerable, IEnumerator {

protected override ST_f45a100349e05fd4d70690aea76ddd0aStructure GetElementDefaultValue() {
return new ST_f45a100349e05fd4d70690aea76ddd0aStructure();
}

public T[] ToArray<T>(Func<ST_f45a100349e05fd4d70690aea76ddd0aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1f2dce8131c11e514c7e3f0c7ba2a8ef recordList, Func<ST_f45a100349e05fd4d70690aea76ddd0aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1f2dce8131c11e514c7e3f0c7ba2a8ef(ST_f45a100349e05fd4d70690aea76ddd0aStructure[] array) {
  RL_1f2dce8131c11e514c7e3f0c7ba2a8ef result = new RL_1f2dce8131c11e514c7e3f0c7ba2a8ef();
result.InnerFromArray(array);
    return result;
}

public static RL_1f2dce8131c11e514c7e3f0c7ba2a8ef ToList<T>(T[] array, Func <T, ST_f45a100349e05fd4d70690aea76ddd0aStructure> converter) {
  RL_1f2dce8131c11e514c7e3f0c7ba2a8ef result = new RL_1f2dce8131c11e514c7e3f0c7ba2a8ef();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1f2dce8131c11e514c7e3f0c7ba2a8ef FromRestList<T>(RestList<T> restList, Func <T, ST_f45a100349e05fd4d70690aea76ddd0aStructure> converter) {
  RL_1f2dce8131c11e514c7e3f0c7ba2a8ef result = new RL_1f2dce8131c11e514c7e3f0c7ba2a8ef();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1f2dce8131c11e514c7e3f0c7ba2a8ef() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f45a100349e05fd4d70690aea76ddd0aStructure> NewList() {
return new RL_1f2dce8131c11e514c7e3f0c7ba2a8ef();
}


} // RL_1f2dce8131c11e514c7e3f0c7ba2a8ef
}

