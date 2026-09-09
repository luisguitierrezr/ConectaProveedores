namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fTa1kGKwPkOVK2vyfVN81g)
///  <code>RC_b668eee4846e2937101a51355804499d</code> that represents <code>InvoiceFolioRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceFolioRecord
public partial struct RC_b668eee4846e2937101a51355804499d : ITypedRecord<RC_b668eee4846e2937101a51355804499d> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;


public BitArray OptimizedAttributes;

public RC_b668eee4846e2937101a51355804499d() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
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
public void ReadIM(RC_b668eee4846e2937101a51355804499d r) {
this = r;
}


public static bool operator == (RC_b668eee4846e2937101a51355804499d a, RC_b668eee4846e2937101a51355804499d b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
return true;
}

public static bool operator != (RC_b668eee4846e2937101a51355804499d a, RC_b668eee4846e2937101a51355804499d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b668eee4846e2937101a51355804499d)) return false;
return (this == (RC_b668eee4846e2937101a51355804499d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
}


public RC_b668eee4846e2937101a51355804499d Duplicate() {
RC_b668eee4846e2937101a51355804499d t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
}
} // RC_b668eee4846e2937101a51355804499d
/// <summary>
/// RecordList type <code>InvoiceFolioRecordList</code> that represents a record list of <code>Invoice,
///  Folio</code>
/// </summary>
public partial class RL_d94294de88e7b9437b2238f21bdccaff : GenericRecordList<RC_b668eee4846e2937101a51355804499d>, IEnumerable, IEnumerator {

protected override RC_b668eee4846e2937101a51355804499d GetElementDefaultValue() {
return new RC_b668eee4846e2937101a51355804499d();
}

public T[] ToArray<T>(Func<RC_b668eee4846e2937101a51355804499d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d94294de88e7b9437b2238f21bdccaff recordList, Func<RC_b668eee4846e2937101a51355804499d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d94294de88e7b9437b2238f21bdccaff(RC_b668eee4846e2937101a51355804499d[] array) {
  RL_d94294de88e7b9437b2238f21bdccaff result = new RL_d94294de88e7b9437b2238f21bdccaff();
result.InnerFromArray(array);
    return result;
}

public static RL_d94294de88e7b9437b2238f21bdccaff ToList<T>(T[] array, Func <T, RC_b668eee4846e2937101a51355804499d> converter) {
  RL_d94294de88e7b9437b2238f21bdccaff result = new RL_d94294de88e7b9437b2238f21bdccaff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d94294de88e7b9437b2238f21bdccaff FromRestList<T>(RestList<T> restList, Func <T, RC_b668eee4846e2937101a51355804499d> converter) {
  RL_d94294de88e7b9437b2238f21bdccaff result = new RL_d94294de88e7b9437b2238f21bdccaff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d94294de88e7b9437b2238f21bdccaff() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b668eee4846e2937101a51355804499d> NewList() {
return new RL_d94294de88e7b9437b2238f21bdccaff();
}


} // RL_d94294de88e7b9437b2238f21bdccaff
}

