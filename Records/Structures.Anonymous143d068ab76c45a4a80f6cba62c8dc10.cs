namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (igY9FGy3pEWoD2y6YsjcEA)
///  <code>RC_71c861973e22846762035e2ce8e6ef99</code> that represent
/// s <code>OrderMainCompanyRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainCompanyRegionRecord
public partial struct RC_71c861973e22846762035e2ce8e6ef99 : ITypedRecord<RC_71c861973e22846762035e2ce8e6ef99> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_71c861973e22846762035e2ce8e6ef99() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(11,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENCompany.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENCompany.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
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
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_71c861973e22846762035e2ce8e6ef99 r) {
this = r;
}


public static bool operator == (RC_71c861973e22846762035e2ce8e6ef99 a, RC_71c861973e22846762035e2ce8e6ef99 b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_71c861973e22846762035e2ce8e6ef99 a, RC_71c861973e22846762035e2ce8e6ef99 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_71c861973e22846762035e2ce8e6ef99)) return false;
return (this == (RC_71c861973e22846762035e2ce8e6ef99)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENCompany.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_71c861973e22846762035e2ce8e6ef99 Duplicate() {
RC_71c861973e22846762035e2ce8e6ef99 t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdCompany) {
return ssENCompany;
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
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_71c861973e22846762035e2ce8e6ef99
/// <summary>
/// RecordList type <code>OrderMainCompanyRegionRecordList</code> that represents a record list of
///  <code>OrderMain, Company, Region</code>
/// </summary>
public partial class RL_c8bbb75c7d09bde1f237fa0b721125bc : GenericRecordList<RC_71c861973e22846762035e2ce8e6ef99>, IEnumerable, IEnumerator {

protected override RC_71c861973e22846762035e2ce8e6ef99 GetElementDefaultValue() {
return new RC_71c861973e22846762035e2ce8e6ef99();
}

public T[] ToArray<T>(Func<RC_71c861973e22846762035e2ce8e6ef99, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c8bbb75c7d09bde1f237fa0b721125bc recordList, Func<RC_71c861973e22846762035e2ce8e6ef99, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c8bbb75c7d09bde1f237fa0b721125bc(RC_71c861973e22846762035e2ce8e6ef99[] array) {
  RL_c8bbb75c7d09bde1f237fa0b721125bc result = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
result.InnerFromArray(array);
    return result;
}

public static RL_c8bbb75c7d09bde1f237fa0b721125bc ToList<T>(T[] array, Func <T, RC_71c861973e22846762035e2ce8e6ef99> converter) {
  RL_c8bbb75c7d09bde1f237fa0b721125bc result = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c8bbb75c7d09bde1f237fa0b721125bc FromRestList<T>(RestList<T> restList, Func <T, RC_71c861973e22846762035e2ce8e6ef99> converter) {
  RL_c8bbb75c7d09bde1f237fa0b721125bc result = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c8bbb75c7d09bde1f237fa0b721125bc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(29,false);
def[1] = new BitArray(11,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_71c861973e22846762035e2ce8e6ef99> NewList() {
return new RL_c8bbb75c7d09bde1f237fa0b721125bc();
}


} // RL_c8bbb75c7d09bde1f237fa0b721125bc
}

