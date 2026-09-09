namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2d4KSQM+b0egUa4FMagnuw)
///  <code>RC_428141695aee6b3458a97f3fa044a69e</code> that represent
/// s <code>FolioOrderMainSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioOrderMainSupplierRegionRecord
public partial struct RC_428141695aee6b3458a97f3fa044a69e : ITypedRecord<RC_428141695aee6b3458a97f3fa044a69e> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_428141695aee6b3458a97f3fa044a69e() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(28,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_428141695aee6b3458a97f3fa044a69e r) {
this = r;
}


public static bool operator == (RC_428141695aee6b3458a97f3fa044a69e a, RC_428141695aee6b3458a97f3fa044a69e b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_428141695aee6b3458a97f3fa044a69e a, RC_428141695aee6b3458a97f3fa044a69e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_428141695aee6b3458a97f3fa044a69e)) return false;
return (this == (RC_428141695aee6b3458a97f3fa044a69e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_428141695aee6b3458a97f3fa044a69e Duplicate() {
RC_428141695aee6b3458a97f3fa044a69e t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_428141695aee6b3458a97f3fa044a69e
/// <summary>
/// RecordList type <code>FolioOrderMainSupplierRegionRecordList</code> that represents a record list
///  of <code>Folio, OrderMain, Supplier, Region</code>
/// </summary>
public partial class RL_06da8a08cec85e816e2153470a02256e : GenericRecordList<RC_428141695aee6b3458a97f3fa044a69e>, IEnumerable, IEnumerator {

protected override RC_428141695aee6b3458a97f3fa044a69e GetElementDefaultValue() {
return new RC_428141695aee6b3458a97f3fa044a69e();
}

public T[] ToArray<T>(Func<RC_428141695aee6b3458a97f3fa044a69e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_06da8a08cec85e816e2153470a02256e recordList, Func<RC_428141695aee6b3458a97f3fa044a69e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_06da8a08cec85e816e2153470a02256e(RC_428141695aee6b3458a97f3fa044a69e[] array) {
  RL_06da8a08cec85e816e2153470a02256e result = new RL_06da8a08cec85e816e2153470a02256e();
result.InnerFromArray(array);
    return result;
}

public static RL_06da8a08cec85e816e2153470a02256e ToList<T>(T[] array, Func <T, RC_428141695aee6b3458a97f3fa044a69e> converter) {
  RL_06da8a08cec85e816e2153470a02256e result = new RL_06da8a08cec85e816e2153470a02256e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_06da8a08cec85e816e2153470a02256e FromRestList<T>(RestList<T> restList, Func <T, RC_428141695aee6b3458a97f3fa044a69e> converter) {
  RL_06da8a08cec85e816e2153470a02256e result = new RL_06da8a08cec85e816e2153470a02256e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_06da8a08cec85e816e2153470a02256e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(20,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(28,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_428141695aee6b3458a97f3fa044a69e> NewList() {
return new RL_06da8a08cec85e816e2153470a02256e();
}


} // RL_06da8a08cec85e816e2153470a02256e
}

