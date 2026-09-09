namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SjGvjTV8akWJJDD5tN4gMg)
///  <code>RC_90f26addd0e4ccd849615a93fb01d4c5</code> that represents <code>RowsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RowsRecord
public partial struct RC_90f26addd0e4ccd849615a93fb01d4c5 : ITypedRecord<RC_90f26addd0e4ccd849615a93fb01d4c5> {
internal static readonly GlobalObjectKey IdRows = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3WrykOTQ2MxJYVqT+wHUxQ");

public ST_3fd667dc2513888f6027df59e05def3fStructure ssSTRows;


public static implicit operator ST_3fd667dc2513888f6027df59e05def3fStructure( RC_90f26addd0e4ccd849615a93fb01d4c5 r) {
return r.ssSTRows;
}

public static implicit operator RC_90f26addd0e4ccd849615a93fb01d4c5 (ST_3fd667dc2513888f6027df59e05def3fStructure r) {
RC_90f26addd0e4ccd849615a93fb01d4c5 res = new RC_90f26addd0e4ccd849615a93fb01d4c5 ();
res.ssSTRows = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_90f26addd0e4ccd849615a93fb01d4c5() {
OptimizedAttributes = null;
ssSTRows = new ST_3fd667dc2513888f6027df59e05def3fStructure();
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
    ssSTRows.OptimizedAttributes = value[0];
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
ssSTRows.Read( r, ref index);
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
public void ReadIM(RC_90f26addd0e4ccd849615a93fb01d4c5 r) {
this = r;
}


public static bool operator == (RC_90f26addd0e4ccd849615a93fb01d4c5 a, RC_90f26addd0e4ccd849615a93fb01d4c5 b) {
if (a.ssSTRows != b.ssSTRows) return false;
return true;
}

public static bool operator != (RC_90f26addd0e4ccd849615a93fb01d4c5 a, RC_90f26addd0e4ccd849615a93fb01d4c5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_90f26addd0e4ccd849615a93fb01d4c5)) return false;
return (this == (RC_90f26addd0e4ccd849615a93fb01d4c5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRows.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRows.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRows.InternalRecursiveSave();
}


public RC_90f26addd0e4ccd849615a93fb01d4c5 Duplicate() {
RC_90f26addd0e4ccd849615a93fb01d4c5 t;
t.ssSTRows = (ST_3fd667dc2513888f6027df59e05def3fStructure)this.ssSTRows.Duplicate();
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
if (head == "rows") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Rows")) variable.Value = ssSTRows; else variable.Optimized = true;
variable.SetFieldName("rows");
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
if (key == IdRows) {
return ssSTRows;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRows.Key.AsGuid) {
return ssSTRows;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRows.FillFromOther((IRecord) other.AttributeGet(IdRows));
}
} // RC_90f26addd0e4ccd849615a93fb01d4c5
/// <summary>
/// RecordList type <code>RowsRecordList</code> that represents a record list of <code>Rows</code>
/// </summary>
public partial class RL_7a2b9e482ba18b6e35d504cc60e1b18e : GenericRecordList<RC_90f26addd0e4ccd849615a93fb01d4c5>, IEnumerable, IEnumerator {

protected override RC_90f26addd0e4ccd849615a93fb01d4c5 GetElementDefaultValue() {
return new RC_90f26addd0e4ccd849615a93fb01d4c5();
}

public T[] ToArray<T>(Func<RC_90f26addd0e4ccd849615a93fb01d4c5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7a2b9e482ba18b6e35d504cc60e1b18e recordList, Func<RC_90f26addd0e4ccd849615a93fb01d4c5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7a2b9e482ba18b6e35d504cc60e1b18e(RC_90f26addd0e4ccd849615a93fb01d4c5[] array) {
  RL_7a2b9e482ba18b6e35d504cc60e1b18e result = new RL_7a2b9e482ba18b6e35d504cc60e1b18e();
result.InnerFromArray(array);
    return result;
}

public static RL_7a2b9e482ba18b6e35d504cc60e1b18e ToList<T>(T[] array, Func <T, RC_90f26addd0e4ccd849615a93fb01d4c5> converter) {
  RL_7a2b9e482ba18b6e35d504cc60e1b18e result = new RL_7a2b9e482ba18b6e35d504cc60e1b18e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7a2b9e482ba18b6e35d504cc60e1b18e FromRestList<T>(RestList<T> restList, Func <T, RC_90f26addd0e4ccd849615a93fb01d4c5> converter) {
  RL_7a2b9e482ba18b6e35d504cc60e1b18e result = new RL_7a2b9e482ba18b6e35d504cc60e1b18e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7a2b9e482ba18b6e35d504cc60e1b18e() : base() {
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
protected override OSList<RC_90f26addd0e4ccd849615a93fb01d4c5> NewList() {
return new RL_7a2b9e482ba18b6e35d504cc60e1b18e();
}


} // RL_7a2b9e482ba18b6e35d504cc60e1b18e
}

