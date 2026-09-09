namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_ESTD_CUENTA_COSMOZReq (xHGWuip6VEueY5W9x_kRYg)
///  <code>ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure</code> that represent
/// s <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReq</code> <p>Description: ZMXMIMMF_ESTD_CUENTA_COSMOZReq</p>
/// </summary>
// Name: ZMXMIMMF_ESTD_CUENTA_COSMOZReq
public partial struct ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure : ITypedRecord<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> {
internal static readonly GlobalObjectKey IdI_ACREEDOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*hVbpeF0K_UCBAkGyxd8x5w");
internal static readonly GlobalObjectKey IdI_ANTICIPOS_HIGH = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*4pW9_1USkUudnMGt23D7iQ");
internal static readonly GlobalObjectKey IdI_ANTICIPOS_LOW = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Q_N1+GB9VkacAvmr10fp1w");
internal static readonly GlobalObjectKey IdI_F_PARTABIE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Unx80KXG0UG4SNXlQ4ue0Q");
internal static readonly GlobalObjectKey IdI_PCOMP_HIGH = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*bxHUSMeQQ0uLXPus7o0KeQ");
internal static readonly GlobalObjectKey IdI_PCOMP_LOW = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8JAzpFE_xUOTwKvIFduQ+Q");
internal static readonly GlobalObjectKey IdI_REGION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*bEXRH6PunkqKdXrjWzn5dw");
internal static readonly GlobalObjectKey IdI_SOCIEDAD = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*iKJsW4fYS0Gs7N2l8B2gPQ");
internal static readonly GlobalObjectKey IdT_DAT_PROV_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Wyk7iuZ90E2u+Sfcxa36rQ");
internal static readonly GlobalObjectKey IdT_FACT_PEN_PAG_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*eiAmiMG_w0+kAp6fmJSIKA");
internal static readonly GlobalObjectKey IdT_FAC_PAG_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*rzTmr9RnE0a1CfvZt4Ljgg");
internal static readonly GlobalObjectKey IdT_FAC_PAG_CAB_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*cWOMgM5VIku+qYittnemZg");

public string ssI_ACREEDOR;

public string ssI_ANTICIPOS_HIGH;

public string ssI_ANTICIPOS_LOW;

public string ssI_F_PARTABIE;

public string ssI_PCOMP_HIGH;

public string ssI_PCOMP_LOW;

public string ssI_REGION;

public string ssI_SOCIEDAD;

public RL_26f0bf6a8c3a397fae12e4e85231dc16 ssT_DAT_PROV_In;

public RL_544a92ac2b1a23d422d8e47df2b48a91 ssT_FACT_PEN_PAG_In;

public RL_152e8e5fa3664ba75db709725278e7f8 ssT_FAC_PAG_In;

public RL_26adac9723b2e9519247bc502c06c341 ssT_FAC_PAG_CAB_In;


public BitArray OptimizedAttributes;

public ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure() {
OptimizedAttributes = null;
ssI_ACREEDOR = "";
ssI_ANTICIPOS_HIGH = "";
ssI_ANTICIPOS_LOW = "";
ssI_F_PARTABIE = "";
ssI_PCOMP_HIGH = "";
ssI_PCOMP_LOW = "";
ssI_REGION = "";
ssI_SOCIEDAD = "";
ssT_DAT_PROV_In = new RL_26f0bf6a8c3a397fae12e4e85231dc16();
ssT_FACT_PEN_PAG_In = new RL_544a92ac2b1a23d422d8e47df2b48a91();
ssT_FAC_PAG_In = new RL_152e8e5fa3664ba75db709725278e7f8();
ssT_FAC_PAG_CAB_In = new RL_26adac9723b2e9519247bc502c06c341();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssI_ACREEDOR = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_ACREEDOR", "");
ssI_ANTICIPOS_HIGH = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_ANTICIPOS_HIGH", "");
ssI_ANTICIPOS_LOW = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_ANTICIPOS_LOW", "");
ssI_F_PARTABIE = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_F_PARTABIE", "");
ssI_PCOMP_HIGH = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_PCOMP_HIGH", "");
ssI_PCOMP_LOW = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_PCOMP_LOW", "");
ssI_REGION = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_REGION", "");
ssI_SOCIEDAD = r.ReadText(index++, "ZMXMIMMF_ESTD_CUENTA_COSMOZReq.I_SOCIEDAD", "");
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
public void ReadIM(ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure r) {
this = r;
}


public static bool operator == (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure a, ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure b) {
if (a.ssI_ACREEDOR != b.ssI_ACREEDOR) return false;
if (a.ssI_ANTICIPOS_HIGH != b.ssI_ANTICIPOS_HIGH) return false;
if (a.ssI_ANTICIPOS_LOW != b.ssI_ANTICIPOS_LOW) return false;
if (a.ssI_F_PARTABIE != b.ssI_F_PARTABIE) return false;
if (a.ssI_PCOMP_HIGH != b.ssI_PCOMP_HIGH) return false;
if (a.ssI_PCOMP_LOW != b.ssI_PCOMP_LOW) return false;
if (a.ssI_REGION != b.ssI_REGION) return false;
if (a.ssI_SOCIEDAD != b.ssI_SOCIEDAD) return false;
if (a.ssT_DAT_PROV_In != b.ssT_DAT_PROV_In) return false;
if (a.ssT_FACT_PEN_PAG_In != b.ssT_FACT_PEN_PAG_In) return false;
if (a.ssT_FAC_PAG_In != b.ssT_FAC_PAG_In) return false;
if (a.ssT_FAC_PAG_CAB_In != b.ssT_FAC_PAG_CAB_In) return false;
return true;
}

public static bool operator != (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure a, ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure)) return false;
return (this == (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssI_ACREEDOR.GetHashCode()
 ^ ssI_ANTICIPOS_HIGH.GetHashCode()
 ^ ssI_ANTICIPOS_LOW.GetHashCode()
 ^ ssI_F_PARTABIE.GetHashCode()
 ^ ssI_PCOMP_HIGH.GetHashCode()
 ^ ssI_PCOMP_LOW.GetHashCode()
 ^ ssI_REGION.GetHashCode()
 ^ ssI_SOCIEDAD.GetHashCode()
 ^ ssT_DAT_PROV_In.GetHashCode()
 ^ ssT_FACT_PEN_PAG_In.GetHashCode()
 ^ ssT_FAC_PAG_In.GetHashCode()
 ^ ssT_FAC_PAG_CAB_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssT_DAT_PROV_In.RecursiveReset();
ssT_FACT_PEN_PAG_In.RecursiveReset();
ssT_FAC_PAG_In.RecursiveReset();
ssT_FAC_PAG_CAB_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssT_DAT_PROV_In.InternalRecursiveSave();
ssT_FACT_PEN_PAG_In.InternalRecursiveSave();
ssT_FAC_PAG_In.InternalRecursiveSave();
ssT_FAC_PAG_CAB_In.InternalRecursiveSave();
}


public ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure Duplicate() {
ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure t;
t.ssI_ACREEDOR = this.ssI_ACREEDOR;
t.ssI_ANTICIPOS_HIGH = this.ssI_ANTICIPOS_HIGH;
t.ssI_ANTICIPOS_LOW = this.ssI_ANTICIPOS_LOW;
t.ssI_F_PARTABIE = this.ssI_F_PARTABIE;
t.ssI_PCOMP_HIGH = this.ssI_PCOMP_HIGH;
t.ssI_PCOMP_LOW = this.ssI_PCOMP_LOW;
t.ssI_REGION = this.ssI_REGION;
t.ssI_SOCIEDAD = this.ssI_SOCIEDAD;
t.ssT_DAT_PROV_In = (RL_26f0bf6a8c3a397fae12e4e85231dc16)this.ssT_DAT_PROV_In.Duplicate();
t.ssT_FACT_PEN_PAG_In = (RL_544a92ac2b1a23d422d8e47df2b48a91)this.ssT_FACT_PEN_PAG_In.Duplicate();
t.ssT_FAC_PAG_In = (RL_152e8e5fa3664ba75db709725278e7f8)this.ssT_FAC_PAG_In.Duplicate();
t.ssT_FAC_PAG_CAB_In = (RL_26adac9723b2e9519247bc502c06c341)this.ssT_FAC_PAG_CAB_In.Duplicate();
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
if (head == "i_acreedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_ACREEDOR")) variable.Value = ssI_ACREEDOR; else variable.Optimized = true;
} else if (head == "i_anticipos_high") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_ANTICIPOS_HIGH")) variable.Value = ssI_ANTICIPOS_HIGH; else variable.Optimized = true;
} else if (head == "i_anticipos_low") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_ANTICIPOS_LOW")) variable.Value = ssI_ANTICIPOS_LOW; else variable.Optimized = true;
} else if (head == "i_f_partabie") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_F_PARTABIE")) variable.Value = ssI_F_PARTABIE; else variable.Optimized = true;
} else if (head == "i_pcomp_high") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_PCOMP_HIGH")) variable.Value = ssI_PCOMP_HIGH; else variable.Optimized = true;
} else if (head == "i_pcomp_low") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_PCOMP_LOW")) variable.Value = ssI_PCOMP_LOW; else variable.Optimized = true;
} else if (head == "i_region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_REGION")) variable.Value = ssI_REGION; else variable.Optimized = true;
} else if (head == "i_sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".I_SOCIEDAD")) variable.Value = ssI_SOCIEDAD; else variable.Optimized = true;
} else if (head == "t_dat_prov_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_DAT_PROV_In")) variable.Value = ssT_DAT_PROV_In; else variable.Optimized = true;
variable.SetFieldName("t_dat_prov_in");
} else if (head == "t_fact_pen_pag_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FACT_PEN_PAG_In")) variable.Value = ssT_FACT_PEN_PAG_In; else variable.Optimized = true;
variable.SetFieldName("t_fact_pen_pag_in");
} else if (head == "t_fac_pag_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_In")) variable.Value = ssT_FAC_PAG_In; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_in");
} else if (head == "t_fac_pag_cab_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_CAB_In")) variable.Value = ssT_FAC_PAG_CAB_In; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_cab_in");
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
if (key == IdI_ACREEDOR) {
return ssI_ACREEDOR;
}
if (key == IdI_ANTICIPOS_HIGH) {
return ssI_ANTICIPOS_HIGH;
}
if (key == IdI_ANTICIPOS_LOW) {
return ssI_ANTICIPOS_LOW;
}
if (key == IdI_F_PARTABIE) {
return ssI_F_PARTABIE;
}
if (key == IdI_PCOMP_HIGH) {
return ssI_PCOMP_HIGH;
}
if (key == IdI_PCOMP_LOW) {
return ssI_PCOMP_LOW;
}
if (key == IdI_REGION) {
return ssI_REGION;
}
if (key == IdI_SOCIEDAD) {
return ssI_SOCIEDAD;
}
if (key == IdT_DAT_PROV_In) {
return ssT_DAT_PROV_In;
}
if (key == IdT_FACT_PEN_PAG_In) {
return ssT_FACT_PEN_PAG_In;
}
if (key == IdT_FAC_PAG_In) {
return ssT_FAC_PAG_In;
}
if (key == IdT_FAC_PAG_CAB_In) {
return ssT_FAC_PAG_CAB_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdI_ACREEDOR.Key.AsGuid) {
return ssI_ACREEDOR;
}
if (attributeKey == IdI_ANTICIPOS_HIGH.Key.AsGuid) {
return ssI_ANTICIPOS_HIGH;
}
if (attributeKey == IdI_ANTICIPOS_LOW.Key.AsGuid) {
return ssI_ANTICIPOS_LOW;
}
if (attributeKey == IdI_F_PARTABIE.Key.AsGuid) {
return ssI_F_PARTABIE;
}
if (attributeKey == IdI_PCOMP_HIGH.Key.AsGuid) {
return ssI_PCOMP_HIGH;
}
if (attributeKey == IdI_PCOMP_LOW.Key.AsGuid) {
return ssI_PCOMP_LOW;
}
if (attributeKey == IdI_REGION.Key.AsGuid) {
return ssI_REGION;
}
if (attributeKey == IdI_SOCIEDAD.Key.AsGuid) {
return ssI_SOCIEDAD;
}
if (attributeKey == IdT_DAT_PROV_In.Key.AsGuid) {
return ssT_DAT_PROV_In;
}
if (attributeKey == IdT_FACT_PEN_PAG_In.Key.AsGuid) {
return ssT_FACT_PEN_PAG_In;
}
if (attributeKey == IdT_FAC_PAG_In.Key.AsGuid) {
return ssT_FAC_PAG_In;
}
if (attributeKey == IdT_FAC_PAG_CAB_In.Key.AsGuid) {
return ssT_FAC_PAG_CAB_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssI_ACREEDOR = (string) other.AttributeGet(IdI_ACREEDOR);
ssI_ANTICIPOS_HIGH = (string) other.AttributeGet(IdI_ANTICIPOS_HIGH);
ssI_ANTICIPOS_LOW = (string) other.AttributeGet(IdI_ANTICIPOS_LOW);
ssI_F_PARTABIE = (string) other.AttributeGet(IdI_F_PARTABIE);
ssI_PCOMP_HIGH = (string) other.AttributeGet(IdI_PCOMP_HIGH);
ssI_PCOMP_LOW = (string) other.AttributeGet(IdI_PCOMP_LOW);
ssI_REGION = (string) other.AttributeGet(IdI_REGION);
ssI_SOCIEDAD = (string) other.AttributeGet(IdI_SOCIEDAD);
ssT_DAT_PROV_In = new RL_26f0bf6a8c3a397fae12e4e85231dc16();
ssT_DAT_PROV_In.FillFromOther((IOSList) other.AttributeGet(IdT_DAT_PROV_In));
ssT_FACT_PEN_PAG_In = new RL_544a92ac2b1a23d422d8e47df2b48a91();
ssT_FACT_PEN_PAG_In.FillFromOther((IOSList) other.AttributeGet(IdT_FACT_PEN_PAG_In));
ssT_FAC_PAG_In = new RL_152e8e5fa3664ba75db709725278e7f8();
ssT_FAC_PAG_In.FillFromOther((IOSList) other.AttributeGet(IdT_FAC_PAG_In));
ssT_FAC_PAG_CAB_In = new RL_26adac9723b2e9519247bc502c06c341();
ssT_FAC_PAG_CAB_In.FillFromOther((IOSList) other.AttributeGet(IdT_FAC_PAG_CAB_In));
}
} // ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure
/// <summary>
/// RecordList type <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReqList</code> that represents a record list of
///  <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReq</code>
/// </summary>
public partial class RL_69c46658f4baccc6faf7c3ea628d6fba : GenericRecordList<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure>, IEnumerable, IEnumerator {

protected override ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure GetElementDefaultValue() {
return new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure();
}

public T[] ToArray<T>(Func<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_69c46658f4baccc6faf7c3ea628d6fba recordList, Func<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_69c46658f4baccc6faf7c3ea628d6fba(ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure[] array) {
  RL_69c46658f4baccc6faf7c3ea628d6fba result = new RL_69c46658f4baccc6faf7c3ea628d6fba();
result.InnerFromArray(array);
    return result;
}

public static RL_69c46658f4baccc6faf7c3ea628d6fba ToList<T>(T[] array, Func <T, ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> converter) {
  RL_69c46658f4baccc6faf7c3ea628d6fba result = new RL_69c46658f4baccc6faf7c3ea628d6fba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_69c46658f4baccc6faf7c3ea628d6fba FromRestList<T>(RestList<T> restList, Func <T, ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> converter) {
  RL_69c46658f4baccc6faf7c3ea628d6fba result = new RL_69c46658f4baccc6faf7c3ea628d6fba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_69c46658f4baccc6faf7c3ea628d6fba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure> NewList() {
return new RL_69c46658f4baccc6faf7c3ea628d6fba();
}


} // RL_69c46658f4baccc6faf7c3ea628d6fba
}

