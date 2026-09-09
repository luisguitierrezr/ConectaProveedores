namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Q1KGLFllq0+WOULlZH+L3A)
///  <code>RC_2e7d78681454c0e1bbb6a38d7fddd8cd</code> that represent
/// s <code>InvoicesScreenTableStructureRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicesScreenTableStructureRecord
public partial struct RC_2e7d78681454c0e1bbb6a38d7fddd8cd : ITypedRecord<RC_2e7d78681454c0e1bbb6a38d7fddd8cd> {
internal static readonly GlobalObjectKey IdInvoicesScreenTableStructure = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aHh9LlQU4cC7tqONf93YzQ");

public ST_3c6142d371d14231f5ddee7b64c28681Structure ssSTInvoicesScreenTableStructure;


public static implicit operator ST_3c6142d371d14231f5ddee7b64c28681Structure( RC_2e7d78681454c0e1bbb6a38d7fddd8cd r) {
return r.ssSTInvoicesScreenTableStructure;
}

public static implicit operator RC_2e7d78681454c0e1bbb6a38d7fddd8cd (ST_3c6142d371d14231f5ddee7b64c28681Structure r) {
RC_2e7d78681454c0e1bbb6a38d7fddd8cd res = new RC_2e7d78681454c0e1bbb6a38d7fddd8cd ();
res.ssSTInvoicesScreenTableStructure = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2e7d78681454c0e1bbb6a38d7fddd8cd() {
OptimizedAttributes = null;
ssSTInvoicesScreenTableStructure = new ST_3c6142d371d14231f5ddee7b64c28681Structure();
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
    ssSTInvoicesScreenTableStructure.OptimizedAttributes = value[0];
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
ssSTInvoicesScreenTableStructure.Read( r, ref index);
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
public void ReadIM(RC_2e7d78681454c0e1bbb6a38d7fddd8cd r) {
this = r;
}


public static bool operator == (RC_2e7d78681454c0e1bbb6a38d7fddd8cd a, RC_2e7d78681454c0e1bbb6a38d7fddd8cd b) {
if (a.ssSTInvoicesScreenTableStructure != b.ssSTInvoicesScreenTableStructure) return false;
return true;
}

public static bool operator != (RC_2e7d78681454c0e1bbb6a38d7fddd8cd a, RC_2e7d78681454c0e1bbb6a38d7fddd8cd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2e7d78681454c0e1bbb6a38d7fddd8cd)) return false;
return (this == (RC_2e7d78681454c0e1bbb6a38d7fddd8cd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoicesScreenTableStructure.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoicesScreenTableStructure.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoicesScreenTableStructure.InternalRecursiveSave();
}


public RC_2e7d78681454c0e1bbb6a38d7fddd8cd Duplicate() {
RC_2e7d78681454c0e1bbb6a38d7fddd8cd t;
t.ssSTInvoicesScreenTableStructure = (ST_3c6142d371d14231f5ddee7b64c28681Structure)this.ssSTInvoicesScreenTableStructure.Duplicate();
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
if (head == "invoicesscreentablestructure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesScreenTableStructure")) variable.Value = ssSTInvoicesScreenTableStructure; else variable.Optimized = true;
variable.SetFieldName("invoicesscreentablestructure");
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
if (key == IdInvoicesScreenTableStructure) {
return ssSTInvoicesScreenTableStructure;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesScreenTableStructure.Key.AsGuid) {
return ssSTInvoicesScreenTableStructure;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoicesScreenTableStructure.FillFromOther((IRecord) other.AttributeGet(IdInvoicesScreenTableStructure));
}
} // RC_2e7d78681454c0e1bbb6a38d7fddd8cd
/// <summary>
/// RecordList type <code>InvoicesScreenTableStructureRecordList</code> that represents a record list
///  of <code>InvoicesScreenTableStructure</code>
/// </summary>
public partial class RL_4e3668f56eb8d73847e1c7c44f4206e8 : GenericRecordList<RC_2e7d78681454c0e1bbb6a38d7fddd8cd>, IEnumerable, IEnumerator {

protected override RC_2e7d78681454c0e1bbb6a38d7fddd8cd GetElementDefaultValue() {
return new RC_2e7d78681454c0e1bbb6a38d7fddd8cd();
}

public T[] ToArray<T>(Func<RC_2e7d78681454c0e1bbb6a38d7fddd8cd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4e3668f56eb8d73847e1c7c44f4206e8 recordList, Func<RC_2e7d78681454c0e1bbb6a38d7fddd8cd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4e3668f56eb8d73847e1c7c44f4206e8(RC_2e7d78681454c0e1bbb6a38d7fddd8cd[] array) {
  RL_4e3668f56eb8d73847e1c7c44f4206e8 result = new RL_4e3668f56eb8d73847e1c7c44f4206e8();
result.InnerFromArray(array);
    return result;
}

public static RL_4e3668f56eb8d73847e1c7c44f4206e8 ToList<T>(T[] array, Func <T, RC_2e7d78681454c0e1bbb6a38d7fddd8cd> converter) {
  RL_4e3668f56eb8d73847e1c7c44f4206e8 result = new RL_4e3668f56eb8d73847e1c7c44f4206e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4e3668f56eb8d73847e1c7c44f4206e8 FromRestList<T>(RestList<T> restList, Func <T, RC_2e7d78681454c0e1bbb6a38d7fddd8cd> converter) {
  RL_4e3668f56eb8d73847e1c7c44f4206e8 result = new RL_4e3668f56eb8d73847e1c7c44f4206e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4e3668f56eb8d73847e1c7c44f4206e8() : base() {
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
protected override OSList<RC_2e7d78681454c0e1bbb6a38d7fddd8cd> NewList() {
return new RL_4e3668f56eb8d73847e1c7c44f4206e8();
}


} // RL_4e3668f56eb8d73847e1c7c44f4206e8
}

