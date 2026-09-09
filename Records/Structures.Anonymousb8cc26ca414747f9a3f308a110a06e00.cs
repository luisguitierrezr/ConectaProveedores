namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yibMuEdB+Uej8wihEKBuAA)
///  <code>RC_759c053ad9cffaec26c59da8e40042d4</code> that represent
/// s <code>InvoiceExtendedRelationsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedRelationsRecord
public partial struct RC_759c053ad9cffaec26c59da8e40042d4 : ITypedRecord<RC_759c053ad9cffaec26c59da8e40042d4> {
internal static readonly GlobalObjectKey IdInvoiceExtendedRelations = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OgWcdc_Z7PomxZ2o5ABC1A");

public EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord ssENInvoiceExtendedRelations;


public static implicit operator EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord( RC_759c053ad9cffaec26c59da8e40042d4 r) {
return r.ssENInvoiceExtendedRelations;
}

public static implicit operator RC_759c053ad9cffaec26c59da8e40042d4 (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord r) {
RC_759c053ad9cffaec26c59da8e40042d4 res = new RC_759c053ad9cffaec26c59da8e40042d4 ();
res.ssENInvoiceExtendedRelations = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedRelations.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedRelations.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_759c053ad9cffaec26c59da8e40042d4() {
OptimizedAttributes = null;
ssENInvoiceExtendedRelations = new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedRelations.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedRelations.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedRelations.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedRelations.Read( r, ref index);
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
public void ReadIM(RC_759c053ad9cffaec26c59da8e40042d4 r) {
this = r;
}


public static bool operator == (RC_759c053ad9cffaec26c59da8e40042d4 a, RC_759c053ad9cffaec26c59da8e40042d4 b) {
if (a.ssENInvoiceExtendedRelations != b.ssENInvoiceExtendedRelations) return false;
return true;
}

public static bool operator != (RC_759c053ad9cffaec26c59da8e40042d4 a, RC_759c053ad9cffaec26c59da8e40042d4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_759c053ad9cffaec26c59da8e40042d4)) return false;
return (this == (RC_759c053ad9cffaec26c59da8e40042d4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedRelations.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedRelations.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedRelations.InternalRecursiveSave();
}


public RC_759c053ad9cffaec26c59da8e40042d4 Duplicate() {
RC_759c053ad9cffaec26c59da8e40042d4 t;
t.ssENInvoiceExtendedRelations = (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord)this.ssENInvoiceExtendedRelations.Duplicate();
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
if (head == "invoiceextendedrelations") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedRelations")) variable.Value = ssENInvoiceExtendedRelations; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedrelations");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedRelations.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedRelations.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedRelations) {
return ssENInvoiceExtendedRelations;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedRelations.Key.AsGuid) {
return ssENInvoiceExtendedRelations;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedRelations.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedRelations));
}
} // RC_759c053ad9cffaec26c59da8e40042d4
/// <summary>
/// RecordList type <code>InvoiceExtendedRelationsRecordList</code> that represents a record list of
///  <code>InvoiceExtendedRelations</code>
/// </summary>
public partial class RL_d07e089b14ae41d13cfd90c5313de016 : GenericRecordList<RC_759c053ad9cffaec26c59da8e40042d4>, IEnumerable, IEnumerator {

protected override RC_759c053ad9cffaec26c59da8e40042d4 GetElementDefaultValue() {
return new RC_759c053ad9cffaec26c59da8e40042d4();
}

public T[] ToArray<T>(Func<RC_759c053ad9cffaec26c59da8e40042d4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d07e089b14ae41d13cfd90c5313de016 recordList, Func<RC_759c053ad9cffaec26c59da8e40042d4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d07e089b14ae41d13cfd90c5313de016(RC_759c053ad9cffaec26c59da8e40042d4[] array) {
  RL_d07e089b14ae41d13cfd90c5313de016 result = new RL_d07e089b14ae41d13cfd90c5313de016();
result.InnerFromArray(array);
    return result;
}

public static RL_d07e089b14ae41d13cfd90c5313de016 ToList<T>(T[] array, Func <T, RC_759c053ad9cffaec26c59da8e40042d4> converter) {
  RL_d07e089b14ae41d13cfd90c5313de016 result = new RL_d07e089b14ae41d13cfd90c5313de016();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d07e089b14ae41d13cfd90c5313de016 FromRestList<T>(RestList<T> restList, Func <T, RC_759c053ad9cffaec26c59da8e40042d4> converter) {
  RL_d07e089b14ae41d13cfd90c5313de016 result = new RL_d07e089b14ae41d13cfd90c5313de016();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d07e089b14ae41d13cfd90c5313de016() : base() {
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
protected override OSList<RC_759c053ad9cffaec26c59da8e40042d4> NewList() {
return new RL_d07e089b14ae41d13cfd90c5313de016();
}


} // RL_d07e089b14ae41d13cfd90c5313de016
}

