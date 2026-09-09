namespace ssConectaProveedores {
/// <summary>
/// [Structure] ValidDateStruc (sidxNRWIeUalo8nm_+mouA)
///  <code>ST_360c3a66fc9951d9de7870c1f87f9bf6Structure</code> that represent
/// s <code>ValidDateStruc</code> <p>Description: </p>
/// </summary>
// Name: ValidDateStruc
public partial struct ST_360c3a66fc9951d9de7870c1f87f9bf6Structure : ITypedRecord<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> {
internal static readonly GlobalObjectKey IdIsValid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IjD2JieWmUy2HuX9OddPbw");
internal static readonly GlobalObjectKey IdDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VskustXPgEuowghTuRloow");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ey1SnGu1Lke02jWg9JSFdg");

public bool ssIsValid;

public DateTime ssDate;

public string ssErrorMessage;


public BitArray OptimizedAttributes;

public ST_360c3a66fc9951d9de7870c1f87f9bf6Structure() {
OptimizedAttributes = null;
ssIsValid = true;
ssDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssErrorMessage = "";
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
ssIsValid = r.ReadBoolean(index++, "ValidDateStruc.IsValid", false);
ssDate = r.ReadDate(index++, "ValidDateStruc.Date", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssErrorMessage = r.ReadText(index++, "ValidDateStruc.ErrorMessage", "");
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
public void ReadIM(ST_360c3a66fc9951d9de7870c1f87f9bf6Structure r) {
this = r;
}


public static bool operator == (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure a, ST_360c3a66fc9951d9de7870c1f87f9bf6Structure b) {
if (a.ssIsValid != b.ssIsValid) return false;
if (a.ssDate != b.ssDate) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure a, ST_360c3a66fc9951d9de7870c1f87f9bf6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure)) return false;
return (this == (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsValid.GetHashCode()
 ^ ssDate.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_360c3a66fc9951d9de7870c1f87f9bf6Structure Duplicate() {
ST_360c3a66fc9951d9de7870c1f87f9bf6Structure t;
t.ssIsValid = this.ssIsValid;
t.ssDate = this.ssDate;
t.ssErrorMessage = this.ssErrorMessage;
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
if (head == "isvalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsValid")) variable.Value = ssIsValid; else variable.Optimized = true;
} else if (head == "date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Date")) variable.Value = ssDate; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
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
if (key == IdIsValid) {
return ssIsValid;
}
if (key == IdDate) {
return ssDate;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsValid.Key.AsGuid) {
return ssIsValid;
}
if (attributeKey == IdDate.Key.AsGuid) {
return ssDate;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsValid = (bool) other.AttributeGet(IdIsValid);
ssDate = (DateTime) other.AttributeGet(IdDate);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
}
} // ST_360c3a66fc9951d9de7870c1f87f9bf6Structure
/// <summary>
/// RecordList type <code>ValidDateStrucList</code> that represents a record list of
///  <code>ValidDateStruc</code>
/// </summary>
public partial class RL_c1c236adf4233f7be57f5ad7f8602363 : GenericRecordList<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure>, IEnumerable, IEnumerator {

protected override ST_360c3a66fc9951d9de7870c1f87f9bf6Structure GetElementDefaultValue() {
return new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure();
}

public T[] ToArray<T>(Func<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c1c236adf4233f7be57f5ad7f8602363 recordList, Func<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c1c236adf4233f7be57f5ad7f8602363(ST_360c3a66fc9951d9de7870c1f87f9bf6Structure[] array) {
  RL_c1c236adf4233f7be57f5ad7f8602363 result = new RL_c1c236adf4233f7be57f5ad7f8602363();
result.InnerFromArray(array);
    return result;
}

public static RL_c1c236adf4233f7be57f5ad7f8602363 ToList<T>(T[] array, Func <T, ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> converter) {
  RL_c1c236adf4233f7be57f5ad7f8602363 result = new RL_c1c236adf4233f7be57f5ad7f8602363();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c1c236adf4233f7be57f5ad7f8602363 FromRestList<T>(RestList<T> restList, Func <T, ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> converter) {
  RL_c1c236adf4233f7be57f5ad7f8602363 result = new RL_c1c236adf4233f7be57f5ad7f8602363();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c1c236adf4233f7be57f5ad7f8602363() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> NewList() {
return new RL_c1c236adf4233f7be57f5ad7f8602363();
}


} // RL_c1c236adf4233f7be57f5ad7f8602363
}

