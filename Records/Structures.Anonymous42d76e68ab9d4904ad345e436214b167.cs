namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aG7XQp2rBEmtNF5DYhSxZw)
///  <code>RC_ea55d9469159caabdb6018b439e3950d</code> that represents <code>ResultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ResultRecord
public partial struct RC_ea55d9469159caabdb6018b439e3950d : ITypedRecord<RC_ea55d9469159caabdb6018b439e3950d> {
internal static readonly GlobalObjectKey IdResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RtlV6lmRq8rbYBi0OeOVDQ");

public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure ssSTResult;


public static implicit operator ST_38509e9fbd36a9b928c2f4e34a1342aeStructure( RC_ea55d9469159caabdb6018b439e3950d r) {
return r.ssSTResult;
}

public static implicit operator RC_ea55d9469159caabdb6018b439e3950d (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure r) {
RC_ea55d9469159caabdb6018b439e3950d res = new RC_ea55d9469159caabdb6018b439e3950d ();
res.ssSTResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ea55d9469159caabdb6018b439e3950d() {
OptimizedAttributes = null;
ssSTResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
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
    ssSTResult.OptimizedAttributes = value[0];
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
ssSTResult.Read( r, ref index);
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
public void ReadIM(RC_ea55d9469159caabdb6018b439e3950d r) {
this = r;
}


public static bool operator == (RC_ea55d9469159caabdb6018b439e3950d a, RC_ea55d9469159caabdb6018b439e3950d b) {
if (a.ssSTResult != b.ssSTResult) return false;
return true;
}

public static bool operator != (RC_ea55d9469159caabdb6018b439e3950d a, RC_ea55d9469159caabdb6018b439e3950d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ea55d9469159caabdb6018b439e3950d)) return false;
return (this == (RC_ea55d9469159caabdb6018b439e3950d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTResult.InternalRecursiveSave();
}


public RC_ea55d9469159caabdb6018b439e3950d Duplicate() {
RC_ea55d9469159caabdb6018b439e3950d t;
t.ssSTResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)this.ssSTResult.Duplicate();
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
if (head == "result") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Result")) variable.Value = ssSTResult; else variable.Optimized = true;
variable.SetFieldName("result");
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
if (key == IdResult) {
return ssSTResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdResult.Key.AsGuid) {
return ssSTResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTResult.FillFromOther((IRecord) other.AttributeGet(IdResult));
}
} // RC_ea55d9469159caabdb6018b439e3950d
/// <summary>
/// RecordList type <code>ResultRecordList</code> that represents a record list of <code>Result</code>
/// </summary>
public partial class RL_f5ab476251b5a05cc9bc6ef1ce0c4341 : GenericRecordList<RC_ea55d9469159caabdb6018b439e3950d>, IEnumerable, IEnumerator {

protected override RC_ea55d9469159caabdb6018b439e3950d GetElementDefaultValue() {
return new RC_ea55d9469159caabdb6018b439e3950d();
}

public T[] ToArray<T>(Func<RC_ea55d9469159caabdb6018b439e3950d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5ab476251b5a05cc9bc6ef1ce0c4341 recordList, Func<RC_ea55d9469159caabdb6018b439e3950d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5ab476251b5a05cc9bc6ef1ce0c4341(RC_ea55d9469159caabdb6018b439e3950d[] array) {
  RL_f5ab476251b5a05cc9bc6ef1ce0c4341 result = new RL_f5ab476251b5a05cc9bc6ef1ce0c4341();
result.InnerFromArray(array);
    return result;
}

public static RL_f5ab476251b5a05cc9bc6ef1ce0c4341 ToList<T>(T[] array, Func <T, RC_ea55d9469159caabdb6018b439e3950d> converter) {
  RL_f5ab476251b5a05cc9bc6ef1ce0c4341 result = new RL_f5ab476251b5a05cc9bc6ef1ce0c4341();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5ab476251b5a05cc9bc6ef1ce0c4341 FromRestList<T>(RestList<T> restList, Func <T, RC_ea55d9469159caabdb6018b439e3950d> converter) {
  RL_f5ab476251b5a05cc9bc6ef1ce0c4341 result = new RL_f5ab476251b5a05cc9bc6ef1ce0c4341();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5ab476251b5a05cc9bc6ef1ce0c4341() : base() {
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
protected override OSList<RC_ea55d9469159caabdb6018b439e3950d> NewList() {
return new RL_f5ab476251b5a05cc9bc6ef1ce0c4341();
}


} // RL_f5ab476251b5a05cc9bc6ef1ce0c4341
}

