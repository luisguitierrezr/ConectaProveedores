namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ej4xswiThk2rW8z2dcl4Qw)
///  <code>RC_03b2a2565369f3088e5267bce38cfba9</code> that represent
/// s <code>OrderMainOrderDetailSupplierPaymentTermsPaymentMethodsRegionRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: OrderMainOrderDetailSupplierPaymentTermsPaymentMethodsRegionRecord
public partial struct RC_03b2a2565369f3088e5267bce38cfba9 : ITypedRecord<RC_03b2a2565369f3088e5267bce38cfba9> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_03b2a2565369f3088e5267bce38cfba9() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(39,false);
    all[2] = new BitArray(28,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(9,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENOrderDetail.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    ssENPaymentTerms.OptimizedAttributes = value[3];
    ssENPaymentMethods.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENOrderDetail.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
    all[3] = ssENPaymentTerms.OptimizedAttributes;
    all[4] = ssENPaymentMethods.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
ssENPaymentMethods.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_03b2a2565369f3088e5267bce38cfba9 r) {
this = r;
}


public static bool operator == (RC_03b2a2565369f3088e5267bce38cfba9 a, RC_03b2a2565369f3088e5267bce38cfba9 b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_03b2a2565369f3088e5267bce38cfba9 a, RC_03b2a2565369f3088e5267bce38cfba9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_03b2a2565369f3088e5267bce38cfba9)) return false;
return (this == (RC_03b2a2565369f3088e5267bce38cfba9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENPaymentMethods.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENPaymentMethods.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_03b2a2565369f3088e5267bce38cfba9 Duplicate() {
RC_03b2a2565369f3088e5267bce38cfba9 t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
t.ssENPaymentMethods = (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)this.ssENPaymentMethods.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
} else if (head == "paymentmethods") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethods")) variable.Value = ssENPaymentMethods; else variable.Optimized = true;
variable.SetFieldName("paymentmethods");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
if (key == IdPaymentMethods) {
return ssENPaymentMethods;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
if (attributeKey == IdPaymentMethods.Key.AsGuid) {
return ssENPaymentMethods;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_03b2a2565369f3088e5267bce38cfba9
/// <summary>
/// RecordList type <code>OrderMainOrderDetailSupplierPaymentTermsPaymentMethodsRegionRecordList</code>
///  that represents a record list of <code>OrderMain, OrderDetail, Supplier, PaymentTerms
/// , PaymentMethods, Region</code>
/// </summary>
public partial class RL_398a2e7b47dcd31617b8f6499aea0bce : GenericRecordList<RC_03b2a2565369f3088e5267bce38cfba9>, IEnumerable, IEnumerator {

protected override RC_03b2a2565369f3088e5267bce38cfba9 GetElementDefaultValue() {
return new RC_03b2a2565369f3088e5267bce38cfba9();
}

public T[] ToArray<T>(Func<RC_03b2a2565369f3088e5267bce38cfba9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_398a2e7b47dcd31617b8f6499aea0bce recordList, Func<RC_03b2a2565369f3088e5267bce38cfba9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_398a2e7b47dcd31617b8f6499aea0bce(RC_03b2a2565369f3088e5267bce38cfba9[] array) {
  RL_398a2e7b47dcd31617b8f6499aea0bce result = new RL_398a2e7b47dcd31617b8f6499aea0bce();
result.InnerFromArray(array);
    return result;
}

public static RL_398a2e7b47dcd31617b8f6499aea0bce ToList<T>(T[] array, Func <T, RC_03b2a2565369f3088e5267bce38cfba9> converter) {
  RL_398a2e7b47dcd31617b8f6499aea0bce result = new RL_398a2e7b47dcd31617b8f6499aea0bce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_398a2e7b47dcd31617b8f6499aea0bce FromRestList<T>(RestList<T> restList, Func <T, RC_03b2a2565369f3088e5267bce38cfba9> converter) {
  RL_398a2e7b47dcd31617b8f6499aea0bce result = new RL_398a2e7b47dcd31617b8f6499aea0bce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_398a2e7b47dcd31617b8f6499aea0bce() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(29,false);
def[1] = new BitArray(39,false);
def[2] = new BitArray(28,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(9,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_03b2a2565369f3088e5267bce38cfba9> NewList() {
return new RL_398a2e7b47dcd31617b8f6499aea0bce();
}


} // RL_398a2e7b47dcd31617b8f6499aea0bce
}

