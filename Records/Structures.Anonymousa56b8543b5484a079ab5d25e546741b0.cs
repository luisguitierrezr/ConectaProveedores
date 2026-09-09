namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Q4VrpUi1B0qatdJeVGdBsA)
///  <code>RC_21f3e2fd18d91908a16d2c0ca969f965</code> that represents <code>OperatorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OperatorRecord
public partial struct RC_21f3e2fd18d91908a16d2c0ca969f965 : ITypedRecord<RC_21f3e2fd18d91908a16d2c0ca969f965> {
internal static readonly GlobalObjectKey IdOperator = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_eLzIdkYCBmhbSwMqWn5ZQ");

public EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord ssENOperator;


public static implicit operator EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord( RC_21f3e2fd18d91908a16d2c0ca969f965 r) {
return r.ssENOperator;
}

public static implicit operator RC_21f3e2fd18d91908a16d2c0ca969f965 (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord r) {
RC_21f3e2fd18d91908a16d2c0ca969f965 res = new RC_21f3e2fd18d91908a16d2c0ca969f965 ();
res.ssENOperator = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOperator.ChangedAttributes = value;
}
get {
    return ssENOperator.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_21f3e2fd18d91908a16d2c0ca969f965() {
OptimizedAttributes = null;
ssENOperator = new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOperator.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOperator.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOperator.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOperator.Read( r, ref index);
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
public void ReadIM(RC_21f3e2fd18d91908a16d2c0ca969f965 r) {
this = r;
}


public static bool operator == (RC_21f3e2fd18d91908a16d2c0ca969f965 a, RC_21f3e2fd18d91908a16d2c0ca969f965 b) {
if (a.ssENOperator != b.ssENOperator) return false;
return true;
}

public static bool operator != (RC_21f3e2fd18d91908a16d2c0ca969f965 a, RC_21f3e2fd18d91908a16d2c0ca969f965 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_21f3e2fd18d91908a16d2c0ca969f965)) return false;
return (this == (RC_21f3e2fd18d91908a16d2c0ca969f965)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOperator.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOperator.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOperator.InternalRecursiveSave();
}


public RC_21f3e2fd18d91908a16d2c0ca969f965 Duplicate() {
RC_21f3e2fd18d91908a16d2c0ca969f965 t;
t.ssENOperator = (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord)this.ssENOperator.Duplicate();
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
if (head == "operator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Operator")) variable.Value = ssENOperator; else variable.Optimized = true;
variable.SetFieldName("operator");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOperator.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOperator.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOperator) {
return ssENOperator;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOperator.Key.AsGuid) {
return ssENOperator;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOperator.FillFromOther((IRecord) other.AttributeGet(IdOperator));
}
} // RC_21f3e2fd18d91908a16d2c0ca969f965
/// <summary>
/// RecordList type <code>OperatorRecordList</code> that represents a record list of
///  <code>Operator</code>
/// </summary>
public partial class RL_f03e17396f660361b67a45f0e1101893 : GenericRecordList<RC_21f3e2fd18d91908a16d2c0ca969f965>, IEnumerable, IEnumerator {

protected override RC_21f3e2fd18d91908a16d2c0ca969f965 GetElementDefaultValue() {
return new RC_21f3e2fd18d91908a16d2c0ca969f965();
}

public T[] ToArray<T>(Func<RC_21f3e2fd18d91908a16d2c0ca969f965, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f03e17396f660361b67a45f0e1101893 recordList, Func<RC_21f3e2fd18d91908a16d2c0ca969f965, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f03e17396f660361b67a45f0e1101893(RC_21f3e2fd18d91908a16d2c0ca969f965[] array) {
  RL_f03e17396f660361b67a45f0e1101893 result = new RL_f03e17396f660361b67a45f0e1101893();
result.InnerFromArray(array);
    return result;
}

public static RL_f03e17396f660361b67a45f0e1101893 ToList<T>(T[] array, Func <T, RC_21f3e2fd18d91908a16d2c0ca969f965> converter) {
  RL_f03e17396f660361b67a45f0e1101893 result = new RL_f03e17396f660361b67a45f0e1101893();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f03e17396f660361b67a45f0e1101893 FromRestList<T>(RestList<T> restList, Func <T, RC_21f3e2fd18d91908a16d2c0ca969f965> converter) {
  RL_f03e17396f660361b67a45f0e1101893 result = new RL_f03e17396f660361b67a45f0e1101893();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f03e17396f660361b67a45f0e1101893() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_21f3e2fd18d91908a16d2c0ca969f965> NewList() {
return new RL_f03e17396f660361b67a45f0e1101893();
}


} // RL_f03e17396f660361b67a45f0e1101893
}

