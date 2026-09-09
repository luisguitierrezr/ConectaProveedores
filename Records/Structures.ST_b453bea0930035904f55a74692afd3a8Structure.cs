namespace ssConectaProveedores {
/// <summary>
/// [Structure] Valid (LX6U769anEaFUURR_6yULg)
///  <code>ST_b453bea0930035904f55a74692afd3a8Structure</code> that represents <code>Valid</code
/// > <p>Description: Valid.</p>
/// </summary>
// Name: Valid
public partial struct ST_b453bea0930035904f55a74692afd3a8Structure : ITypedRecord<ST_b453bea0930035904f55a74692afd3a8Structure> {
internal static readonly GlobalObjectKey IdIsValid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y1nOIiuFXk2U4oKcU3l3KQ");
internal static readonly GlobalObjectKey IdValidationMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Z3W6DBSPSUme51elP5cLsQ");

public bool ssIsValid;

public string ssValidationMessage;


public BitArray OptimizedAttributes;

public ST_b453bea0930035904f55a74692afd3a8Structure() {
OptimizedAttributes = null;
ssIsValid = true;
ssValidationMessage = "";
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
ssIsValid = r.ReadBoolean(index++, "Valid.IsValid", false);
ssValidationMessage = r.ReadText(index++, "Valid.ValidationMessage", "");
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
public void ReadIM(ST_b453bea0930035904f55a74692afd3a8Structure r) {
this = r;
}


public static bool operator == (ST_b453bea0930035904f55a74692afd3a8Structure a, ST_b453bea0930035904f55a74692afd3a8Structure b) {
if (a.ssIsValid != b.ssIsValid) return false;
if (a.ssValidationMessage != b.ssValidationMessage) return false;
return true;
}

public static bool operator != (ST_b453bea0930035904f55a74692afd3a8Structure a, ST_b453bea0930035904f55a74692afd3a8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b453bea0930035904f55a74692afd3a8Structure)) return false;
return (this == (ST_b453bea0930035904f55a74692afd3a8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsValid.GetHashCode()
 ^ ssValidationMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b453bea0930035904f55a74692afd3a8Structure Duplicate() {
ST_b453bea0930035904f55a74692afd3a8Structure t;
t.ssIsValid = this.ssIsValid;
t.ssValidationMessage = this.ssValidationMessage;
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
} else if (head == "validationmessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationMessage")) variable.Value = ssValidationMessage; else variable.Optimized = true;
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
if (key == IdValidationMessage) {
return ssValidationMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsValid.Key.AsGuid) {
return ssIsValid;
}
if (attributeKey == IdValidationMessage.Key.AsGuid) {
return ssValidationMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsValid = (bool) other.AttributeGet(IdIsValid);
ssValidationMessage = (string) other.AttributeGet(IdValidationMessage);
}
} // ST_b453bea0930035904f55a74692afd3a8Structure
/// <summary>
/// RecordList type <code>ValidList</code> that represents a record list of <code>Valid</code>
/// </summary>
public partial class RL_9d339cefe8e903e7932acc56395da3dd : GenericRecordList<ST_b453bea0930035904f55a74692afd3a8Structure>, IEnumerable, IEnumerator {

protected override ST_b453bea0930035904f55a74692afd3a8Structure GetElementDefaultValue() {
return new ST_b453bea0930035904f55a74692afd3a8Structure();
}

public T[] ToArray<T>(Func<ST_b453bea0930035904f55a74692afd3a8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9d339cefe8e903e7932acc56395da3dd recordList, Func<ST_b453bea0930035904f55a74692afd3a8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9d339cefe8e903e7932acc56395da3dd(ST_b453bea0930035904f55a74692afd3a8Structure[] array) {
  RL_9d339cefe8e903e7932acc56395da3dd result = new RL_9d339cefe8e903e7932acc56395da3dd();
result.InnerFromArray(array);
    return result;
}

public static RL_9d339cefe8e903e7932acc56395da3dd ToList<T>(T[] array, Func <T, ST_b453bea0930035904f55a74692afd3a8Structure> converter) {
  RL_9d339cefe8e903e7932acc56395da3dd result = new RL_9d339cefe8e903e7932acc56395da3dd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9d339cefe8e903e7932acc56395da3dd FromRestList<T>(RestList<T> restList, Func <T, ST_b453bea0930035904f55a74692afd3a8Structure> converter) {
  RL_9d339cefe8e903e7932acc56395da3dd result = new RL_9d339cefe8e903e7932acc56395da3dd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9d339cefe8e903e7932acc56395da3dd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b453bea0930035904f55a74692afd3a8Structure> NewList() {
return new RL_9d339cefe8e903e7932acc56395da3dd();
}


} // RL_9d339cefe8e903e7932acc56395da3dd
}

