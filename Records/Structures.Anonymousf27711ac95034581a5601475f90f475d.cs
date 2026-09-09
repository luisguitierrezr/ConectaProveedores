namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rBF38gOVgUWlYBR1+Q9HXQ)
///  <code>RC_eccb78cdb64462c8ad8352ba772acab7</code> that represent
/// s <code>MultiUploadInvoiceFileStructRecord</code> <p>Description: </p>
/// </summary>
// Name: MultiUploadInvoiceFileStructRecord
public partial struct RC_eccb78cdb64462c8ad8352ba772acab7 : ITypedRecord<RC_eccb78cdb64462c8ad8352ba772acab7> {
internal static readonly GlobalObjectKey IdMultiUploadInvoiceFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zXjL7ES2yGKtg1K6dyrKtw");

public ST_5478c3bb197e3019856d4a634c17d91dStructure ssSTMultiUploadInvoiceFileStruct;


public static implicit operator ST_5478c3bb197e3019856d4a634c17d91dStructure( RC_eccb78cdb64462c8ad8352ba772acab7 r) {
return r.ssSTMultiUploadInvoiceFileStruct;
}

public static implicit operator RC_eccb78cdb64462c8ad8352ba772acab7 (ST_5478c3bb197e3019856d4a634c17d91dStructure r) {
RC_eccb78cdb64462c8ad8352ba772acab7 res = new RC_eccb78cdb64462c8ad8352ba772acab7 ();
res.ssSTMultiUploadInvoiceFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_eccb78cdb64462c8ad8352ba772acab7() {
OptimizedAttributes = null;
ssSTMultiUploadInvoiceFileStruct = new ST_5478c3bb197e3019856d4a634c17d91dStructure();
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
    ssSTMultiUploadInvoiceFileStruct.OptimizedAttributes = value[0];
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
ssSTMultiUploadInvoiceFileStruct.Read( r, ref index);
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
public void ReadIM(RC_eccb78cdb64462c8ad8352ba772acab7 r) {
this = r;
}


public static bool operator == (RC_eccb78cdb64462c8ad8352ba772acab7 a, RC_eccb78cdb64462c8ad8352ba772acab7 b) {
if (a.ssSTMultiUploadInvoiceFileStruct != b.ssSTMultiUploadInvoiceFileStruct) return false;
return true;
}

public static bool operator != (RC_eccb78cdb64462c8ad8352ba772acab7 a, RC_eccb78cdb64462c8ad8352ba772acab7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eccb78cdb64462c8ad8352ba772acab7)) return false;
return (this == (RC_eccb78cdb64462c8ad8352ba772acab7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMultiUploadInvoiceFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMultiUploadInvoiceFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMultiUploadInvoiceFileStruct.InternalRecursiveSave();
}


public RC_eccb78cdb64462c8ad8352ba772acab7 Duplicate() {
RC_eccb78cdb64462c8ad8352ba772acab7 t;
t.ssSTMultiUploadInvoiceFileStruct = (ST_5478c3bb197e3019856d4a634c17d91dStructure)this.ssSTMultiUploadInvoiceFileStruct.Duplicate();
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
if (head == "multiuploadinvoicefilestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MultiUploadInvoiceFileStruct")) variable.Value = ssSTMultiUploadInvoiceFileStruct; else variable.Optimized = true;
variable.SetFieldName("multiuploadinvoicefilestruct");
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
if (key == IdMultiUploadInvoiceFileStruct) {
return ssSTMultiUploadInvoiceFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMultiUploadInvoiceFileStruct.Key.AsGuid) {
return ssSTMultiUploadInvoiceFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMultiUploadInvoiceFileStruct.FillFromOther((IRecord) other.AttributeGet(IdMultiUploadInvoiceFileStruct));
}
} // RC_eccb78cdb64462c8ad8352ba772acab7
/// <summary>
/// RecordList type <code>MultiUploadInvoiceFileStructRecordList</code> that represents a record list
///  of <code>MultiUploadInvoiceFileStruct</code>
/// </summary>
public partial class RL_45edc20f13939dd038ad7d1de3478d6c : GenericRecordList<RC_eccb78cdb64462c8ad8352ba772acab7>, IEnumerable, IEnumerator {

protected override RC_eccb78cdb64462c8ad8352ba772acab7 GetElementDefaultValue() {
return new RC_eccb78cdb64462c8ad8352ba772acab7();
}

public T[] ToArray<T>(Func<RC_eccb78cdb64462c8ad8352ba772acab7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_45edc20f13939dd038ad7d1de3478d6c recordList, Func<RC_eccb78cdb64462c8ad8352ba772acab7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_45edc20f13939dd038ad7d1de3478d6c(RC_eccb78cdb64462c8ad8352ba772acab7[] array) {
  RL_45edc20f13939dd038ad7d1de3478d6c result = new RL_45edc20f13939dd038ad7d1de3478d6c();
result.InnerFromArray(array);
    return result;
}

public static RL_45edc20f13939dd038ad7d1de3478d6c ToList<T>(T[] array, Func <T, RC_eccb78cdb64462c8ad8352ba772acab7> converter) {
  RL_45edc20f13939dd038ad7d1de3478d6c result = new RL_45edc20f13939dd038ad7d1de3478d6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_45edc20f13939dd038ad7d1de3478d6c FromRestList<T>(RestList<T> restList, Func <T, RC_eccb78cdb64462c8ad8352ba772acab7> converter) {
  RL_45edc20f13939dd038ad7d1de3478d6c result = new RL_45edc20f13939dd038ad7d1de3478d6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_45edc20f13939dd038ad7d1de3478d6c() : base() {
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
protected override OSList<RC_eccb78cdb64462c8ad8352ba772acab7> NewList() {
return new RL_45edc20f13939dd038ad7d1de3478d6c();
}


} // RL_45edc20f13939dd038ad7d1de3478d6c
}

