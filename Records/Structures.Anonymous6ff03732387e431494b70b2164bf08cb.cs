namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Mjfwb344FEOUtwshZL8Iyw)
///  <code>RC_09565d86b693a4a01e3f6ffec1bd5add</code> that represent
/// s <code>UploadValidationDataRecord</code> <p>Description: </p>
/// </summary>
// Name: UploadValidationDataRecord
public partial struct RC_09565d86b693a4a01e3f6ffec1bd5add : ITypedRecord<RC_09565d86b693a4a01e3f6ffec1bd5add> {
internal static readonly GlobalObjectKey IdUploadValidationData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hl1WCZO2oKQeP2_+wb1a3Q");

public ST_452088c4ad7c6718df20290248661783Structure ssSTUploadValidationData;


public static implicit operator ST_452088c4ad7c6718df20290248661783Structure( RC_09565d86b693a4a01e3f6ffec1bd5add r) {
return r.ssSTUploadValidationData;
}

public static implicit operator RC_09565d86b693a4a01e3f6ffec1bd5add (ST_452088c4ad7c6718df20290248661783Structure r) {
RC_09565d86b693a4a01e3f6ffec1bd5add res = new RC_09565d86b693a4a01e3f6ffec1bd5add ();
res.ssSTUploadValidationData = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_09565d86b693a4a01e3f6ffec1bd5add() {
OptimizedAttributes = null;
ssSTUploadValidationData = new ST_452088c4ad7c6718df20290248661783Structure();
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
    ssSTUploadValidationData.OptimizedAttributes = value[0];
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
ssSTUploadValidationData.Read( r, ref index);
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
public void ReadIM(RC_09565d86b693a4a01e3f6ffec1bd5add r) {
this = r;
}


public static bool operator == (RC_09565d86b693a4a01e3f6ffec1bd5add a, RC_09565d86b693a4a01e3f6ffec1bd5add b) {
if (a.ssSTUploadValidationData != b.ssSTUploadValidationData) return false;
return true;
}

public static bool operator != (RC_09565d86b693a4a01e3f6ffec1bd5add a, RC_09565d86b693a4a01e3f6ffec1bd5add b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_09565d86b693a4a01e3f6ffec1bd5add)) return false;
return (this == (RC_09565d86b693a4a01e3f6ffec1bd5add)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUploadValidationData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUploadValidationData.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUploadValidationData.InternalRecursiveSave();
}


public RC_09565d86b693a4a01e3f6ffec1bd5add Duplicate() {
RC_09565d86b693a4a01e3f6ffec1bd5add t;
t.ssSTUploadValidationData = (ST_452088c4ad7c6718df20290248661783Structure)this.ssSTUploadValidationData.Duplicate();
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
if (head == "uploadvalidationdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadValidationData")) variable.Value = ssSTUploadValidationData; else variable.Optimized = true;
variable.SetFieldName("uploadvalidationdata");
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
if (key == IdUploadValidationData) {
return ssSTUploadValidationData;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUploadValidationData.Key.AsGuid) {
return ssSTUploadValidationData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUploadValidationData.FillFromOther((IRecord) other.AttributeGet(IdUploadValidationData));
}
} // RC_09565d86b693a4a01e3f6ffec1bd5add
/// <summary>
/// RecordList type <code>UploadValidationDataRecordList</code> that represents a record list of
///  <code>UploadValidationData</code>
/// </summary>
public partial class RL_f6ce12e6998d1f3e805b62e0eebd1931 : GenericRecordList<RC_09565d86b693a4a01e3f6ffec1bd5add>, IEnumerable, IEnumerator {

protected override RC_09565d86b693a4a01e3f6ffec1bd5add GetElementDefaultValue() {
return new RC_09565d86b693a4a01e3f6ffec1bd5add();
}

public T[] ToArray<T>(Func<RC_09565d86b693a4a01e3f6ffec1bd5add, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6ce12e6998d1f3e805b62e0eebd1931 recordList, Func<RC_09565d86b693a4a01e3f6ffec1bd5add, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6ce12e6998d1f3e805b62e0eebd1931(RC_09565d86b693a4a01e3f6ffec1bd5add[] array) {
  RL_f6ce12e6998d1f3e805b62e0eebd1931 result = new RL_f6ce12e6998d1f3e805b62e0eebd1931();
result.InnerFromArray(array);
    return result;
}

public static RL_f6ce12e6998d1f3e805b62e0eebd1931 ToList<T>(T[] array, Func <T, RC_09565d86b693a4a01e3f6ffec1bd5add> converter) {
  RL_f6ce12e6998d1f3e805b62e0eebd1931 result = new RL_f6ce12e6998d1f3e805b62e0eebd1931();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6ce12e6998d1f3e805b62e0eebd1931 FromRestList<T>(RestList<T> restList, Func <T, RC_09565d86b693a4a01e3f6ffec1bd5add> converter) {
  RL_f6ce12e6998d1f3e805b62e0eebd1931 result = new RL_f6ce12e6998d1f3e805b62e0eebd1931();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6ce12e6998d1f3e805b62e0eebd1931() : base() {
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
protected override OSList<RC_09565d86b693a4a01e3f6ffec1bd5add> NewList() {
return new RL_f6ce12e6998d1f3e805b62e0eebd1931();
}


} // RL_f6ce12e6998d1f3e805b62e0eebd1931
}

