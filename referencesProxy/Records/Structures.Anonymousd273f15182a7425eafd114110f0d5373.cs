namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (UfFz0qeCXkKv0RQRDw1Tcw)
///  <code>RC_22b8d69f2e3592de5742131565fc1e67</code> that represents <code>CfdFileWrapperRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CfdFileWrapperRecord
public partial struct RC_22b8d69f2e3592de5742131565fc1e67 : ITypedRecord<RC_22b8d69f2e3592de5742131565fc1e67> {
internal static readonly GlobalObjectKey IdCfdFileWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*n9a4IjUu3pJXQhMVZfweZw");

public ST_1e51b813a2c6a26cea1c6c8c17329da8Structure ssSTCfdFileWrapper;


public static implicit operator ST_1e51b813a2c6a26cea1c6c8c17329da8Structure( RC_22b8d69f2e3592de5742131565fc1e67 r) {
return r.ssSTCfdFileWrapper;
}

public static implicit operator RC_22b8d69f2e3592de5742131565fc1e67 (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure r) {
RC_22b8d69f2e3592de5742131565fc1e67 res = new RC_22b8d69f2e3592de5742131565fc1e67 ();
res.ssSTCfdFileWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_22b8d69f2e3592de5742131565fc1e67() {
OptimizedAttributes = null;
ssSTCfdFileWrapper = new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure();
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
    ssSTCfdFileWrapper.OptimizedAttributes = value[0];
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
ssSTCfdFileWrapper.Read( r, ref index);
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
public void ReadIM(RC_22b8d69f2e3592de5742131565fc1e67 r) {
this = r;
}


public static bool operator == (RC_22b8d69f2e3592de5742131565fc1e67 a, RC_22b8d69f2e3592de5742131565fc1e67 b) {
if (a.ssSTCfdFileWrapper != b.ssSTCfdFileWrapper) return false;
return true;
}

public static bool operator != (RC_22b8d69f2e3592de5742131565fc1e67 a, RC_22b8d69f2e3592de5742131565fc1e67 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_22b8d69f2e3592de5742131565fc1e67)) return false;
return (this == (RC_22b8d69f2e3592de5742131565fc1e67)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCfdFileWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCfdFileWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCfdFileWrapper.InternalRecursiveSave();
}


public RC_22b8d69f2e3592de5742131565fc1e67 Duplicate() {
RC_22b8d69f2e3592de5742131565fc1e67 t;
t.ssSTCfdFileWrapper = (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure)this.ssSTCfdFileWrapper.Duplicate();
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
if (head == "cfdfilewrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CfdFileWrapper")) variable.Value = ssSTCfdFileWrapper; else variable.Optimized = true;
variable.SetFieldName("cfdfilewrapper");
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
if (key == IdCfdFileWrapper) {
return ssSTCfdFileWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCfdFileWrapper.Key.AsGuid) {
return ssSTCfdFileWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCfdFileWrapper.FillFromOther((IRecord) other.AttributeGet(IdCfdFileWrapper));
}
} // RC_22b8d69f2e3592de5742131565fc1e67
/// <summary>
/// RecordList type <code>CfdFileWrapperRecordList</code> that represents a record list of
///  <code>CfdFileWrapper</code>
/// </summary>
public partial class RL_b24cc9a7837d6c0874eb4d6e18a6de68 : GenericRecordList<RC_22b8d69f2e3592de5742131565fc1e67>, IEnumerable, IEnumerator {

protected override RC_22b8d69f2e3592de5742131565fc1e67 GetElementDefaultValue() {
return new RC_22b8d69f2e3592de5742131565fc1e67();
}

public T[] ToArray<T>(Func<RC_22b8d69f2e3592de5742131565fc1e67, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b24cc9a7837d6c0874eb4d6e18a6de68 recordList, Func<RC_22b8d69f2e3592de5742131565fc1e67, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b24cc9a7837d6c0874eb4d6e18a6de68(RC_22b8d69f2e3592de5742131565fc1e67[] array) {
  RL_b24cc9a7837d6c0874eb4d6e18a6de68 result = new RL_b24cc9a7837d6c0874eb4d6e18a6de68();
result.InnerFromArray(array);
    return result;
}

public static RL_b24cc9a7837d6c0874eb4d6e18a6de68 ToList<T>(T[] array, Func <T, RC_22b8d69f2e3592de5742131565fc1e67> converter) {
  RL_b24cc9a7837d6c0874eb4d6e18a6de68 result = new RL_b24cc9a7837d6c0874eb4d6e18a6de68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b24cc9a7837d6c0874eb4d6e18a6de68 FromRestList<T>(RestList<T> restList, Func <T, RC_22b8d69f2e3592de5742131565fc1e67> converter) {
  RL_b24cc9a7837d6c0874eb4d6e18a6de68 result = new RL_b24cc9a7837d6c0874eb4d6e18a6de68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b24cc9a7837d6c0874eb4d6e18a6de68() : base() {
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
protected override OSList<RC_22b8d69f2e3592de5742131565fc1e67> NewList() {
return new RL_b24cc9a7837d6c0874eb4d6e18a6de68();
}


} // RL_b24cc9a7837d6c0874eb4d6e18a6de68
}

