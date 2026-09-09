namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZCpXX6Kv+UOQUEb1lkpqFg)
///  <code>RC_bceddfb85670aa95e44aa049194f2b7c</code> that represent
/// s <code>InvoiceExtendedIssuerRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedIssuerRecord
public partial struct RC_bceddfb85670aa95e44aa049194f2b7c : ITypedRecord<RC_bceddfb85670aa95e44aa049194f2b7c> {
internal static readonly GlobalObjectKey IdInvoiceExtendedIssuer = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uN_tvHBWlarkSqBJGU8rfA");

public EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer;


public static implicit operator EN_1ca446167f1a5fee035306f622895668EntityRecord( RC_bceddfb85670aa95e44aa049194f2b7c r) {
return r.ssENInvoiceExtendedIssuer;
}

public static implicit operator RC_bceddfb85670aa95e44aa049194f2b7c (EN_1ca446167f1a5fee035306f622895668EntityRecord r) {
RC_bceddfb85670aa95e44aa049194f2b7c res = new RC_bceddfb85670aa95e44aa049194f2b7c ();
res.ssENInvoiceExtendedIssuer = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedIssuer.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedIssuer.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_bceddfb85670aa95e44aa049194f2b7c() {
OptimizedAttributes = null;
ssENInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedIssuer.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedIssuer.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedIssuer.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedIssuer.Read( r, ref index);
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
public void ReadIM(RC_bceddfb85670aa95e44aa049194f2b7c r) {
this = r;
}


public static bool operator == (RC_bceddfb85670aa95e44aa049194f2b7c a, RC_bceddfb85670aa95e44aa049194f2b7c b) {
if (a.ssENInvoiceExtendedIssuer != b.ssENInvoiceExtendedIssuer) return false;
return true;
}

public static bool operator != (RC_bceddfb85670aa95e44aa049194f2b7c a, RC_bceddfb85670aa95e44aa049194f2b7c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bceddfb85670aa95e44aa049194f2b7c)) return false;
return (this == (RC_bceddfb85670aa95e44aa049194f2b7c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedIssuer.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedIssuer.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedIssuer.InternalRecursiveSave();
}


public RC_bceddfb85670aa95e44aa049194f2b7c Duplicate() {
RC_bceddfb85670aa95e44aa049194f2b7c t;
t.ssENInvoiceExtendedIssuer = (EN_1ca446167f1a5fee035306f622895668EntityRecord)this.ssENInvoiceExtendedIssuer.Duplicate();
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
if (head == "invoiceextendedissuer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedIssuer")) variable.Value = ssENInvoiceExtendedIssuer; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedissuer");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedIssuer.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedIssuer.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedIssuer) {
return ssENInvoiceExtendedIssuer;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedIssuer.Key.AsGuid) {
return ssENInvoiceExtendedIssuer;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedIssuer.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedIssuer));
}
} // RC_bceddfb85670aa95e44aa049194f2b7c
/// <summary>
/// RecordList type <code>InvoiceExtendedIssuerRecordList</code> that represents a record list of
///  <code>InvoiceExtendedIssuer</code>
/// </summary>
public partial class RL_58fbe7ce84d153fe733fe1ed5bd56616 : GenericRecordList<RC_bceddfb85670aa95e44aa049194f2b7c>, IEnumerable, IEnumerator {

protected override RC_bceddfb85670aa95e44aa049194f2b7c GetElementDefaultValue() {
return new RC_bceddfb85670aa95e44aa049194f2b7c();
}

public T[] ToArray<T>(Func<RC_bceddfb85670aa95e44aa049194f2b7c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_58fbe7ce84d153fe733fe1ed5bd56616 recordList, Func<RC_bceddfb85670aa95e44aa049194f2b7c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_58fbe7ce84d153fe733fe1ed5bd56616(RC_bceddfb85670aa95e44aa049194f2b7c[] array) {
  RL_58fbe7ce84d153fe733fe1ed5bd56616 result = new RL_58fbe7ce84d153fe733fe1ed5bd56616();
result.InnerFromArray(array);
    return result;
}

public static RL_58fbe7ce84d153fe733fe1ed5bd56616 ToList<T>(T[] array, Func <T, RC_bceddfb85670aa95e44aa049194f2b7c> converter) {
  RL_58fbe7ce84d153fe733fe1ed5bd56616 result = new RL_58fbe7ce84d153fe733fe1ed5bd56616();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_58fbe7ce84d153fe733fe1ed5bd56616 FromRestList<T>(RestList<T> restList, Func <T, RC_bceddfb85670aa95e44aa049194f2b7c> converter) {
  RL_58fbe7ce84d153fe733fe1ed5bd56616 result = new RL_58fbe7ce84d153fe733fe1ed5bd56616();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_58fbe7ce84d153fe733fe1ed5bd56616() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bceddfb85670aa95e44aa049194f2b7c> NewList() {
return new RL_58fbe7ce84d153fe733fe1ed5bd56616();
}


} // RL_58fbe7ce84d153fe733fe1ed5bd56616
}

