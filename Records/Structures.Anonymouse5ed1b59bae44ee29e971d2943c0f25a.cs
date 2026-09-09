namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (WRvt5eS64k6elx0pQ8DyWg)
///  <code>RC_27b5a164e828de9b90686831c7908b4a</code> that represents <code>ErrorMessageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ErrorMessageRecord
public partial struct RC_27b5a164e828de9b90686831c7908b4a : ITypedRecord<RC_27b5a164e828de9b90686831c7908b4a> {
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZKG1Jyjom96QaGgxx5CLSg");

public ST_b7d405ca4407e572da091e54d07e3bd1Structure ssSTErrorMessage;


public static implicit operator ST_b7d405ca4407e572da091e54d07e3bd1Structure( RC_27b5a164e828de9b90686831c7908b4a r) {
return r.ssSTErrorMessage;
}

public static implicit operator RC_27b5a164e828de9b90686831c7908b4a (ST_b7d405ca4407e572da091e54d07e3bd1Structure r) {
RC_27b5a164e828de9b90686831c7908b4a res = new RC_27b5a164e828de9b90686831c7908b4a ();
res.ssSTErrorMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_27b5a164e828de9b90686831c7908b4a() {
OptimizedAttributes = null;
ssSTErrorMessage = new ST_b7d405ca4407e572da091e54d07e3bd1Structure();
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
    ssSTErrorMessage.OptimizedAttributes = value[0];
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
ssSTErrorMessage.Read( r, ref index);
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
public void ReadIM(RC_27b5a164e828de9b90686831c7908b4a r) {
this = r;
}


public static bool operator == (RC_27b5a164e828de9b90686831c7908b4a a, RC_27b5a164e828de9b90686831c7908b4a b) {
if (a.ssSTErrorMessage != b.ssSTErrorMessage) return false;
return true;
}

public static bool operator != (RC_27b5a164e828de9b90686831c7908b4a a, RC_27b5a164e828de9b90686831c7908b4a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_27b5a164e828de9b90686831c7908b4a)) return false;
return (this == (RC_27b5a164e828de9b90686831c7908b4a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTErrorMessage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTErrorMessage.InternalRecursiveSave();
}


public RC_27b5a164e828de9b90686831c7908b4a Duplicate() {
RC_27b5a164e828de9b90686831c7908b4a t;
t.ssSTErrorMessage = (ST_b7d405ca4407e572da091e54d07e3bd1Structure)this.ssSTErrorMessage.Duplicate();
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
if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssSTErrorMessage; else variable.Optimized = true;
variable.SetFieldName("errormessage");
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
if (key == IdErrorMessage) {
return ssSTErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssSTErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTErrorMessage.FillFromOther((IRecord) other.AttributeGet(IdErrorMessage));
}
} // RC_27b5a164e828de9b90686831c7908b4a
/// <summary>
/// RecordList type <code>ErrorMessageRecordList</code> that represents a record list of
///  <code>ErrorMessage</code>
/// </summary>
public partial class RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f : GenericRecordList<RC_27b5a164e828de9b90686831c7908b4a>, IEnumerable, IEnumerator {

protected override RC_27b5a164e828de9b90686831c7908b4a GetElementDefaultValue() {
return new RC_27b5a164e828de9b90686831c7908b4a();
}

public T[] ToArray<T>(Func<RC_27b5a164e828de9b90686831c7908b4a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f recordList, Func<RC_27b5a164e828de9b90686831c7908b4a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f(RC_27b5a164e828de9b90686831c7908b4a[] array) {
  RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f result = new RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f();
result.InnerFromArray(array);
    return result;
}

public static RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f ToList<T>(T[] array, Func <T, RC_27b5a164e828de9b90686831c7908b4a> converter) {
  RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f result = new RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f FromRestList<T>(RestList<T> restList, Func <T, RC_27b5a164e828de9b90686831c7908b4a> converter) {
  RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f result = new RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f() : base() {
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
protected override OSList<RC_27b5a164e828de9b90686831c7908b4a> NewList() {
return new RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f();
}


} // RL_bf3bc554c395cc3dd0ab1a5b6ac5d91f
}

