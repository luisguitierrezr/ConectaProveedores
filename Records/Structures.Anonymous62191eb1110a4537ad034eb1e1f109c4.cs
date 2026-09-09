namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (sR4ZYgoRN0WtA06x4fEJxA)
///  <code>RC_18990af86f7169e92b712b468e13b947</code> that represents <code>InvoiceFileRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceFileRecord
public partial struct RC_18990af86f7169e92b712b468e13b947 : ITypedRecord<RC_18990af86f7169e92b712b468e13b947> {
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;


public static implicit operator EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord( RC_18990af86f7169e92b712b468e13b947 r) {
return r.ssENInvoiceFile;
}

public static implicit operator RC_18990af86f7169e92b712b468e13b947 (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord r) {
RC_18990af86f7169e92b712b468e13b947 res = new RC_18990af86f7169e92b712b468e13b947 ();
res.ssENInvoiceFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceFile.ChangedAttributes = value;
}
get {
    return ssENInvoiceFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_18990af86f7169e92b712b468e13b947() {
OptimizedAttributes = null;
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceFile.Read( r, ref index);
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
public void ReadIM(RC_18990af86f7169e92b712b468e13b947 r) {
this = r;
}


public static bool operator == (RC_18990af86f7169e92b712b468e13b947 a, RC_18990af86f7169e92b712b468e13b947 b) {
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
return true;
}

public static bool operator != (RC_18990af86f7169e92b712b468e13b947 a, RC_18990af86f7169e92b712b468e13b947 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_18990af86f7169e92b712b468e13b947)) return false;
return (this == (RC_18990af86f7169e92b712b468e13b947)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceFile.InternalRecursiveSave();
}


public RC_18990af86f7169e92b712b468e13b947 Duplicate() {
RC_18990af86f7169e92b712b468e13b947 t;
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
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
if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
}
} // RC_18990af86f7169e92b712b468e13b947
/// <summary>
/// RecordList type <code>InvoiceFileRecordList</code> that represents a record list of
///  <code>InvoiceFile</code>
/// </summary>
public partial class RL_00a03f803f0d49826089181417370afb : GenericRecordList<RC_18990af86f7169e92b712b468e13b947>, IEnumerable, IEnumerator {

protected override RC_18990af86f7169e92b712b468e13b947 GetElementDefaultValue() {
return new RC_18990af86f7169e92b712b468e13b947();
}

public T[] ToArray<T>(Func<RC_18990af86f7169e92b712b468e13b947, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_00a03f803f0d49826089181417370afb recordList, Func<RC_18990af86f7169e92b712b468e13b947, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_00a03f803f0d49826089181417370afb(RC_18990af86f7169e92b712b468e13b947[] array) {
  RL_00a03f803f0d49826089181417370afb result = new RL_00a03f803f0d49826089181417370afb();
result.InnerFromArray(array);
    return result;
}

public static RL_00a03f803f0d49826089181417370afb ToList<T>(T[] array, Func <T, RC_18990af86f7169e92b712b468e13b947> converter) {
  RL_00a03f803f0d49826089181417370afb result = new RL_00a03f803f0d49826089181417370afb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_00a03f803f0d49826089181417370afb FromRestList<T>(RestList<T> restList, Func <T, RC_18990af86f7169e92b712b468e13b947> converter) {
  RL_00a03f803f0d49826089181417370afb result = new RL_00a03f803f0d49826089181417370afb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_00a03f803f0d49826089181417370afb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_18990af86f7169e92b712b468e13b947> NewList() {
return new RL_00a03f803f0d49826089181417370afb();
}


} // RL_00a03f803f0d49826089181417370afb
}

